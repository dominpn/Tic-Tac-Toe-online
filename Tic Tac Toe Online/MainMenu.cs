using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Sockets;
using System.Net;

namespace Tic_Tac_Toe_Online
{
    public partial class MainMenu : Form
    {
        TcpClient client;
        public MainMenu()
        {
            InitializeComponent();
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

        public static bool CheckIp(string ip)
        {
            return (Regex.Match(ip, @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$", RegexOptions.ECMAScript).Success);
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckIp(ServerIpText.Text) == true)
                {
                    PrepareClient();
                    Hide();
                    Board board = new Board("O", "X", client);
                    board.ShowDialog();
                }
                else
                    MessageBox.Show("This is not valid IP adress");
            }
            catch (Exception ex)
            {
                MessageBox.Show("You cannot connect to opponent " + ex);
            }
        }

        private void CreateNewGameButton_Click(object sender, EventArgs e)
        {
            Hide();
            Board board = new Board("X", "O", null);
            board.ShowDialog();
        }

        private void PrepareClient()
        {
            try
            {
                client = new TcpClient();
                IPEndPoint ipEnd = new IPEndPoint(IPAddress.Parse(ServerIpText.Text), 8000);
                client.Connect(ipEnd);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public string GetLocalIPAddress()
        {
            IPAddress[] ipAdressList = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress ip in ipAdressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }

    }
}