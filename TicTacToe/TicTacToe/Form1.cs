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
            int size = int.Parse(txtbx_GridSize.Text);
            Logic.setFieldSize(size); 
            PlayingField.Columns.Clear();
            PlayingField.Rows.Clear();

            for (int i = 0; i < size; i++)
            {
                PlayingField.Columns.Add(new DataGridViewTextBoxColumn());
                PlayingField.Columns[i].Width = 30;
                PlayingField.Rows.Add();
            }
            PopulatePlayingField();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreatePlayingField();
        }

        private void PlayingField_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Logic.CheckCell(e.ColumnIndex, e.RowIndex);
            PopulatePlayingField();
        }

        private void PopulatePlayingField()
        {
            for (int i = 0; i < PlayingField.Columns.Count; i++)
            {
                for (int j = 0; j < PlayingField.Rows.Count; j++)
                {
                    PlayingField[i, j].Value = Logic.GameField[i, j];
                }
            }
        }
    }
}
