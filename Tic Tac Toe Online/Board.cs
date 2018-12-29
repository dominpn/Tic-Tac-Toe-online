using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Online
{
    public partial class Board : Form
    {
        TcpListener listener;
        TcpClient client;
        public StreamReader streamReader;
        public StreamWriter streamWriter;
        public string recieve;
        string mark, opponent_mark;
        public Board(string mark, string opponent_mark, TcpClient client)
        {
            InitializeComponent();
            this.mark = mark;
            this.opponent_mark = opponent_mark;
            GetLocalIPAddress();

            if (client != null)
            {
                this.client = client;
                ChangeButtonsEnabled(false);
            }

            else
            {
                listener = new TcpListener(IPAddress.Any, 8000);
                listener.Start();
                this.client = listener.AcceptTcpClient();
            }


            streamWriter = new StreamWriter(this.client.GetStream());
            streamReader = new StreamReader(this.client.GetStream());
            streamWriter.AutoFlush = true;
            receiverWorker.RunWorkerAsync();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure to exit from appliaction?", "",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = mark;
            button.Enabled = false;
            Send(button.Name);
            if (checkWinner())
            {
                MessageBox.Show("You win!");
            }
        }

        private bool checkWinner()
        {
            return checkDiagonalWinner() || checkHorizontalWinner() || checkVerticalWinner();
        }

        private bool checkHorizontalWinner()
        {
            if ((X1.Text == X2.Text) && (X2.Text == X3.Text) && (X1.Text != "")) {
                return true;
            }

            else if ((Y1.Text == Z2.Text) && (Y2.Text == Z3.Text) && (Y1.Text != "")) {
                return true;
            }

            else if ((Z1.Text == Z2.Text) && (Z2.Text == Z3.Text) && (Z1.Text != "")) {
                return true;
            }

            return false;
        }

        private bool checkVerticalWinner()
        {
            if ((X1.Text == Y1.Text) && (Y1.Text == Z1.Text) && (X1.Text != "")) {
                return true;
            }

            else if ((X2.Text == Y2.Text) && (Y2.Text == Z2.Text) && (X2.Text != "")) {
                return true;
            }

            else if ((X3.Text == Y3.Text) && (Y3.Text == Z3.Text) && (X3.Text != "")) {
                return true;
            }

            return false;
        }

        private bool checkDiagonalWinner()
        {
            if ((X1.Text == Y2.Text) && (Y2.Text == Z3.Text) && (X1.Text != "")) {
                return true;
            }

            else if ((X3.Text == Y2.Text) && (Y2.Text == Z1.Text) && (X3.Text != "")) {
                return true;
            }

            return false;
        }

        private void receiverWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    recieve = "";
                    recieve = streamReader.ReadLine();
                    ShowOpponentMovementOnBoard(recieve);
                    if (checkWinner())
                    {
                        MessageBox.Show("You lose!");
                    }
                    ChangeButtonsEnabled(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    ConnectionLost();
                }
            }
        }

        private void ShowOpponentMovementOnBoard(string field)
        {
            foreach (Control control in Controls)
            {
                if (control is Button && control.Name == field)
                {
                    Invoke(new Action(() =>
                    {
                        control.Text = opponent_mark;
                        control.Enabled = false;
                    }));
                }
            }
        }

        public void GetLocalIPAddress()
        {
            IPAddress[] ipAdressList = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress ip in ipAdressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    IpLabel.Text = "Your IP address: " + ip.ToString();
                    return;
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }

        private void Send(string buttonName)
        {
            if (client.Connected)
            {
                streamWriter.WriteLine(buttonName);
                ChangeButtonsEnabled(false);
            }
            else
            {
                ConnectionLost();
            }
        }

        private void ConnectionLost()
        {
            MessageBox.Show("You lost connection with opponent");
            Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void ChangeButtonsEnabled(bool enabled)
        {
            foreach (Control control in Controls)
            {
                if (control is Button && control.Text == "")
                {
                    if (InvokeRequired)
                    {
                        Invoke(new Action(() =>
                        {
                            control.Enabled = enabled;
                        }));
                    }
                    else
                    {
                        control.Enabled = enabled;
                    }
                }
            }
        }
    }
}
