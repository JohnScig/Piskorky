﻿namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PlayingField = new System.Windows.Forms.DataGridView();
            this.btn_NewGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PlayingField)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayingField
            // 
            this.PlayingField.AllowUserToAddRows = false;
            this.PlayingField.AllowUserToDeleteRows = false;
            this.PlayingField.AllowUserToResizeColumns = false;
            this.PlayingField.AllowUserToResizeRows = false;
            this.PlayingField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayingField.Location = new System.Drawing.Point(12, 56);
            this.PlayingField.Name = "PlayingField";
            this.PlayingField.Size = new System.Drawing.Size(776, 518);
            this.PlayingField.TabIndex = 1;
            this.PlayingField.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PlayingField_CellClick);
            // 
            // btn_NewGame
            // 
            this.btn_NewGame.Location = new System.Drawing.Point(12, 11);
            this.btn_NewGame.Name = "btn_NewGame";
            this.btn_NewGame.Size = new System.Drawing.Size(75, 23);
            this.btn_NewGame.TabIndex = 4;
            this.btn_NewGame.Text = "New Game";
            this.btn_NewGame.UseVisualStyleBackColor = true;
            this.btn_NewGame.Click += new System.EventHandler(this.btn_NewGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 586);
            this.Controls.Add(this.btn_NewGame);
            this.Controls.Add(this.PlayingField);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PlayingField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView PlayingField;
        private System.Windows.Forms.Button btn_NewGame;
    }
}

