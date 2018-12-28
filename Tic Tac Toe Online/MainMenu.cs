using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Tic_Tac_Toe_Online
{
    public partial class MainMenu : Form
    {
        private string serverIP;
        private void SetupTCPClient(string serverIP)
        {
            this.serverIP = serverIP;
        }
        public MainMenu()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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
                    SetupTCPClient(ServerIpText.Text);
                    this.Hide();
                    Board board = new Board("O");
                    board.ShowDialog();
                }
                else
                    MessageBox.Show("This is not valid IP adress");
            }
            catch
            {
                MessageBox.Show("You cannot connect to opponent");
            }
        }

        private void CreateNewGameButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Board board = new Board("X");
            board.ShowDialog();
        }
    }
}