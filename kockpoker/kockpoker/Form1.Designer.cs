
namespace kockpoker
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
            this.button1 = new System.Windows.Forms.Button();
            this.player1box = new System.Windows.Forms.TextBox();
            this.player2box = new System.Windows.Forms.TextBox();
            this.player3box = new System.Windows.Forms.TextBox();
            this.player4box = new System.Windows.Forms.TextBox();
            this.player6box = new System.Windows.Forms.TextBox();
            this.player5box = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(27, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // player1box
            // 
            this.player1box.Location = new System.Drawing.Point(27, 73);
            this.player1box.Name = "player1box";
            this.player1box.Size = new System.Drawing.Size(100, 20);
            this.player1box.TabIndex = 4;
            this.player1box.Text = "Player1";
            // 
            // player2box
            // 
            this.player2box.Location = new System.Drawing.Point(218, 73);
            this.player2box.Name = "player2box";
            this.player2box.Size = new System.Drawing.Size(100, 20);
            this.player2box.TabIndex = 5;
            this.player2box.Text = "Player2";
            // 
            // player3box
            // 
            this.player3box.Location = new System.Drawing.Point(27, 122);
            this.player3box.Name = "player3box";
            this.player3box.Size = new System.Drawing.Size(100, 20);
            this.player3box.TabIndex = 6;
            this.player3box.Text = "Player3";
            // 
            // player4box
            // 
            this.player4box.Location = new System.Drawing.Point(218, 122);
            this.player4box.Name = "player4box";
            this.player4box.Size = new System.Drawing.Size(100, 20);
            this.player4box.TabIndex = 7;
            this.player4box.Text = "Player4";
            // 
            // player6box
            // 
            this.player6box.Location = new System.Drawing.Point(218, 177);
            this.player6box.Name = "player6box";
            this.player6box.Size = new System.Drawing.Size(100, 20);
            this.player6box.TabIndex = 8;
            this.player6box.Text = "Player6";
            // 
            // player5box
            // 
            this.player5box.Location = new System.Drawing.Point(27, 177);
            this.player5box.Name = "player5box";
            this.player5box.Size = new System.Drawing.Size(100, 20);
            this.player5box.TabIndex = 8;
            this.player5box.Text = "Player5";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::kockpoker.Properties.Resources.zsolt;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 420);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(354, 410);
            this.Controls.Add(this.player5box);
            this.Controls.Add(this.player6box);
            this.Controls.Add(this.player4box);
            this.Controls.Add(this.player3box);
            this.Controls.Add(this.player2box);
            this.Controls.Add(this.player1box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(370, 449);
            this.MinimumSize = new System.Drawing.Size(370, 449);
            this.Name = "Form1";
            this.Text = "kjubpokerxd";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox player1box;
        private System.Windows.Forms.TextBox player2box;
        private System.Windows.Forms.TextBox player3box;
        private System.Windows.Forms.TextBox player4box;
        private System.Windows.Forms.TextBox player6box;
        private System.Windows.Forms.TextBox player5box;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

