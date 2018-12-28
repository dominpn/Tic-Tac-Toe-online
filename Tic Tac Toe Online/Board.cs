using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Online
{
    public partial class Board : Form
    {
        string mark;
        public Board(string mark)
        {
            InitializeComponent();
            this.mark = mark;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = this.mark;
            button.Enabled = false;
            if (this.checkWinner()) {
                MessageBox.Show("You win!");
            }
        }

        private bool checkWinner()
        {
            return (this.checkDiagonalWinner() || this.checkHorizontalWinner() || this.checkVerticalWinner());
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
    }
}
