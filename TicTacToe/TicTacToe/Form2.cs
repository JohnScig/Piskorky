using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            Logic.SetFieldSize(int.Parse(textBox3.Text));
            Logic.NumberOfPlayers = int.Parse(textBox1.Text);
            Logic.WinLength = int.Parse(textBox2.Text);
            Logic.PlayerTurn = 1;
            
        }
    }
}
