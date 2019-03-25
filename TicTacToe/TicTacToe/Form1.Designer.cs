namespace TicTacToe
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
            this.btn_Start = new System.Windows.Forms.Button();
            this.PlayingField = new System.Windows.Forms.DataGridView();
            this.txtbx_GridSize = new System.Windows.Forms.TextBox();
            this.label_gridSize = new System.Windows.Forms.Label();
            this.btn_NewGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PlayingField)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(713, 12);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Start Game";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.button1_Click);
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
            // txtbx_GridSize
            // 
            this.txtbx_GridSize.Location = new System.Drawing.Point(607, 14);
            this.txtbx_GridSize.Name = "txtbx_GridSize";
            this.txtbx_GridSize.Size = new System.Drawing.Size(100, 20);
            this.txtbx_GridSize.TabIndex = 2;
            this.txtbx_GridSize.Text = "10";
            // 
            // label_gridSize
            // 
            this.label_gridSize.AutoSize = true;
            this.label_gridSize.Location = new System.Drawing.Point(552, 17);
            this.label_gridSize.Name = "label_gridSize";
            this.label_gridSize.Size = new System.Drawing.Size(49, 13);
            this.label_gridSize.TabIndex = 3;
            this.label_gridSize.Text = "Grid Size";
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
            this.Controls.Add(this.label_gridSize);
            this.Controls.Add(this.txtbx_GridSize);
            this.Controls.Add(this.PlayingField);
            this.Controls.Add(this.btn_Start);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PlayingField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.Button btn_StartGame;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.DataGridView PlayingField;
        private System.Windows.Forms.TextBox txtbx_GridSize;
        private System.Windows.Forms.Label label_gridSize;
        private System.Windows.Forms.Button btn_NewGame;
    }
}

