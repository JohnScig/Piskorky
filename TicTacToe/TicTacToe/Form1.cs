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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            



        }

        void CreatePlayingField()
        {
            //DataGridView PlayingField = new DataGridView();
            //PlayingField.Location = new System.Drawing.Point(50, 50);

            int size = int.Parse(txtbx_GridSize.Text);
            PlayingField.Columns.Clear();
            PlayingField.Rows.Clear();

            for (int i = 0; i < size; i++)
            {
                PlayingField.Columns.Add(new DataGridViewTextBoxColumn());
                PlayingField.Columns[i].Width = 30;
            }
            PlayingField.Rows.Add(size - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            CreatePlayingField();
            PlayingField.Visible = true;
            //label_gridSize.Visible = false;
            //txtbx_GridSize.Visible = false;
            //btn_Start.Visible = false;
            
        }

        private void PlayingField_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void PlayingField_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show($"{e.ColumnIndex}, {e.RowIndex}");

        }
    }
}
