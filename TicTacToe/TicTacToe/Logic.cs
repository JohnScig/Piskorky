using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    static class Logic
    {
        public static int NumberOfPlayers { get; set; } = 2;
        public static int Turn { get; set; } = 0;
        public static int WinLength { get; set; }
        public static int WinCounter { get; set; } = 0;
        public static int FieldSize { get; set; } = 0;

        public static string[,] GameField { get; set; }

        public static string GameToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{NumberOfPlayers}\t{Turn}\t{WinLength}\t{FieldSize}");
            return sb.ToString();
        }

        public static string FieldToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < GameField.GetLength(0); i++)
            {
                for (int j = 0; j < GameField.GetLength(0); j++)
                {
                    if (string.IsNullOrWhiteSpace(GameField[i,j]))
                    {
                        sb.Append (" " + "\t");
                    }
                    else
                    {
                        sb.Append(GameField[i, j] + "\t");
                    }
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }

        public static void CheckCell(int x, int y)
        {

            if (string.IsNullOrWhiteSpace(GameField[x, y]))
            {
                GameField[x, y] = DrawIcon();
                if (CheckWin())
                {
                    MessageBox.Show("Win! Mňam dopíči!");
                }

                Turn++;
            }
            else
            {
                MessageBox.Show($"Field taken");
            }

        }

        public static void SetFieldSize(int size)
        {
            FieldSize = size;
            GameField = new string[size, size];
        }

        public static string DrawIcon()
        {
            switch (Turn%NumberOfPlayers)
            {
                case (0):
                    { return "X"; }
                case (1):
                    { return "O"; }
                case (2):
                    { return "+"; }
                case (3):
                    { return "8"; }
            }
            return "W";

        }

        public static bool CheckWin()
        {
            switch (Turn% NumberOfPlayers)
            {
                case (0):
                    { return (CheckField("X")); }
                case (1):
                    { return (CheckField("O")); }
                case (2):
                    { return (CheckField("+")); }
                case (3):
                    { return (CheckField("8")); }
            }
            return false;
        }

        public static bool CheckField(string mark)
        {
            for (int i = 0; i < GameField.GetLength(0); i++)
            {
                for (int j = 0; j < GameField.GetLength(0); j++)
                {
                    if (GameField[i, j] == mark)
                    {
                        //Vertical Check
                        try
                        {
                            WinCounter = 1;
                            for (int k = 1; k <= WinLength / 2; k++)
                            {
                                if (GameField[i, j - k] == mark)
                                {
                                    WinCounter++;
                                }
                                if (GameField[i, j + k] == mark)
                                {
                                    WinCounter++;
                                }
                            }
                            if (WinCounter >= WinLength)
                            {
                                return true;
                            }
                        }
                        catch (IndexOutOfRangeException)
                        {
                        }

                        //Horizontal Check
                        try
                        {
                            WinCounter = 1;
                            for (int k = 1; k <= WinLength / 2; k++)
                            {
                                if (GameField[i - k, j] == mark)
                                {
                                    WinCounter++;
                                }
                                if (GameField[i + k, j] == mark)
                                {
                                    WinCounter++;
                                }
                            }
                            if (WinCounter >= WinLength)
                            {
                                return true;
                            }
                        }
                        catch (IndexOutOfRangeException)
                        {
                        }

                        //Diagonal UpDownRightLeft Check
                        try
                        {
                            WinCounter = 1;
                            for (int k = 1; k <= WinLength / 2; k++)
                            {
                                if (GameField[i - k, j - k] == mark)
                                {
                                    WinCounter++;
                                }
                                if (GameField[i + k, j + k] == mark)
                                {
                                    WinCounter++;
                                }
                            }
                            if (WinCounter >= WinLength)
                            {
                                return true;
                            }
                        }
                        catch (IndexOutOfRangeException)
                        {
                        }


                        //Diagonal UpDownLeftRight Check
                        try
                        {
                            WinCounter = 1;
                            for (int k = 1; k <= WinLength / 2; k++)
                            {
                                if (GameField[i - k, j + k] == mark)
                                {
                                    WinCounter++;
                                }
                                if (GameField[i + k, j - k] == mark)
                                {
                                    WinCounter++;
                                }
                            }
                            if (WinCounter >= WinLength)
                            {
                                return true;
                            }
                        }
                        catch (IndexOutOfRangeException)
                        {
                        }

                    }
                }
            }


            return false;
        }

        //public static void NextPlayer()
        //{
        //    if (Turn < NumberOfPlayers)
        //    {
        //        Turn++;
        //    }
        //    else
        //    {
        //        Turn = 1;
        //    }
        //}
    }
}
