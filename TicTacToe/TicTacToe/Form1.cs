using System;
using System.Collections;
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

        public int FieldSize { get; set; }
        //public int WinLength { get; set; }
        public int NumOfPlayers { get; set; }

        

        string[] turn01 = new string[2] { "5", "5" };


        void CreatePlayingField()
        {
            FieldSize = Logic.FieldSize;

            PlayingField.Columns.Clear();
            PlayingField.Rows.Clear();

            for (int i = 0; i < FieldSize; i++)
            {
                PlayingField.Columns.Add(new DataGridViewTextBoxColumn());
                PlayingField.Columns[i].Width = 30;
                PlayingField.Rows.Add();
                PlayingField.Rows[i].Height = 30;
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

        private void btn_NewGame_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            //FieldSize = f2.FieldSize;
            //NumOfPlayers = f2.NumOfPlayers;
            //WinLength = f2.WinLength;

            CreatePlayingField();
           
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            DataHandler.SaveGame();
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            DataHandler.LoadGame();
            CreatePlayingField();
            //PopulatePlayingField();

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Logic.GoBack();
            PopulatePlayingField();
        }
    }
}
