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

        public int FieldSize { get; set; }
        public int NumOfPlayers { get; set; }
        public int WinLength { get; set; }


        private void btn_Start_Click(object sender, EventArgs e)
        {
            FieldSize = int.Parse(textBox3.Text);
            Logic.SetFieldSize(FieldSize);
            NumOfPlayers = int.Parse(textBox1.Text);
            Logic.NumberOfPlayers = int.Parse(textBox1.Text);
            WinLength = int.Parse(textBox2.Text);
            Logic.WinLength = int.Parse(textBox2.Text);
            Logic.PlayerTurn = 1;
            this.Close();
        }
    }
}
