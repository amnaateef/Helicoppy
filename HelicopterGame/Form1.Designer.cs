namespace HelicopterGame
{
    partial class Helicoppy
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
            this.components = new System.ComponentModel.Container();
            this.scoreText = new System.Windows.Forms.Label();
            this.HighScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.distanceText = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.smoke = new System.Windows.Forms.PictureBox();
            this.GameOver = new System.Windows.Forms.PictureBox();
            this.hurdleMiddle = new System.Windows.Forms.PictureBox();
            this.hurdleTop = new System.Windows.Forms.PictureBox();
            this.hurdleBottom = new System.Windows.Forms.PictureBox();
            this.helicopter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smoke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hurdleMiddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hurdleTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hurdleBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helicopter)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Transparent;
            this.scoreText.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scoreText.Location = new System.Drawing.Point(10, 10);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(70, 22);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score:";
            // 
            // HighScore
            // 
            this.HighScore.AutoSize = true;
            this.HighScore.BackColor = System.Drawing.Color.Transparent;
            this.HighScore.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HighScore.Location = new System.Drawing.Point(10, 33);
            this.HighScore.Name = "HighScore";
            this.HighScore.Size = new System.Drawing.Size(120, 22);
            this.HighScore.TabIndex = 6;
            this.HighScore.Text = "High Score:";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 10;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // distanceText
            // 
            this.distanceText.AutoSize = true;
            this.distanceText.BackColor = System.Drawing.Color.Transparent;
            this.distanceText.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.distanceText.Location = new System.Drawing.Point(10, 58);
            this.distanceText.Name = "distanceText";
            this.distanceText.Size = new System.Drawing.Size(100, 22);
            this.distanceText.TabIndex = 14;
            this.distanceText.Text = "Distance:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::HelicopterGame.Properties.Resources.press_Enter_to_restart_5_30_2024;
            this.pictureBox4.Location = new System.Drawing.Point(207, 367);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(479, 65);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HelicopterGame.Properties.Resources.right_click_to_start_press_sp_5_19_2024;
            this.pictureBox3.Location = new System.Drawing.Point(100, 367);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(675, 154);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox3_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HelicopterGame.Properties.Resources.helicoppy_5_18_2024;
            this.pictureBox2.Location = new System.Drawing.Point(318, 168);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(531, 163);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HelicopterGame.Properties.Resources.b0dae045525730b9c9e67c2d355a54b7_ezgif_com_crop;
            this.pictureBox1.Location = new System.Drawing.Point(29, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // smoke
            // 
            this.smoke.BackColor = System.Drawing.Color.Transparent;
            this.smoke.Image = global::HelicopterGame.Properties.Resources.yrsV_f;
            this.smoke.Location = new System.Drawing.Point(755, -1);
            this.smoke.Name = "smoke";
            this.smoke.Size = new System.Drawing.Size(94, 115);
            this.smoke.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.smoke.TabIndex = 10;
            this.smoke.TabStop = false;
            this.smoke.Click += new System.EventHandler(this.smoke_Click);
            // 
            // GameOver
            // 
            this.GameOver.BackColor = System.Drawing.Color.Transparent;
            this.GameOver.Image = global::HelicopterGame.Properties.Resources.GAME_OVER;
            this.GameOver.Location = new System.Drawing.Point(207, 245);
            this.GameOver.Name = "GameOver";
            this.GameOver.Size = new System.Drawing.Size(479, 85);
            this.GameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GameOver.TabIndex = 9;
            this.GameOver.TabStop = false;
            // 
            // hurdleMiddle
            // 
            this.hurdleMiddle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.hurdleMiddle.Image = global::HelicopterGame.Properties.Resources.hurdle;
            this.hurdleMiddle.Location = new System.Drawing.Point(794, 276);
            this.hurdleMiddle.Name = "hurdleMiddle";
            this.hurdleMiddle.Size = new System.Drawing.Size(55, 104);
            this.hurdleMiddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hurdleMiddle.TabIndex = 8;
            this.hurdleMiddle.TabStop = false;
            // 
            // hurdleTop
            // 
            this.hurdleTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.hurdleTop.Image = global::HelicopterGame.Properties.Resources.hurdle;
            this.hurdleTop.Location = new System.Drawing.Point(555, 133);
            this.hurdleTop.Name = "hurdleTop";
            this.hurdleTop.Size = new System.Drawing.Size(55, 104);
            this.hurdleTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hurdleTop.TabIndex = 5;
            this.hurdleTop.TabStop = false;
            this.hurdleTop.Click += new System.EventHandler(this.hurdleTop_Click);
            // 
            // hurdleBottom
            // 
            this.hurdleBottom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.hurdleBottom.Image = global::HelicopterGame.Properties.Resources.hurdle;
            this.hurdleBottom.Location = new System.Drawing.Point(360, 403);
            this.hurdleBottom.Name = "hurdleBottom";
            this.hurdleBottom.Size = new System.Drawing.Size(56, 104);
            this.hurdleBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hurdleBottom.TabIndex = 2;
            this.hurdleBottom.TabStop = false;
            // 
            // helicopter
            // 
            this.helicopter.BackColor = System.Drawing.Color.Transparent;
            this.helicopter.Image = global::HelicopterGame.Properties.Resources.b0dae045525730b9c9e67c2d355a54b7_ezgif_com_crop;
            this.helicopter.Location = new System.Drawing.Point(38, 276);
            this.helicopter.Name = "helicopter";
            this.helicopter.Size = new System.Drawing.Size(67, 54);
            this.helicopter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.helicopter.TabIndex = 1;
            this.helicopter.TabStop = false;
            // 
            // Helicoppy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(860, 634);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.distanceText);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.smoke);
            this.Controls.Add(this.GameOver);
            this.Controls.Add(this.hurdleMiddle);
            this.Controls.Add(this.HighScore);
            this.Controls.Add(this.hurdleTop);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.hurdleBottom);
            this.Controls.Add(this.helicopter);
            this.Name = "Helicoppy";
            this.Text = "Helicoppy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gameStart);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gamemouseisdown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gamemouseisup);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smoke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hurdleMiddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hurdleTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hurdleBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helicopter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox helicopter;
        private System.Windows.Forms.PictureBox hurdleBottom;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.PictureBox hurdleTop;
        private System.Windows.Forms.Label HighScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox hurdleMiddle;
        private System.Windows.Forms.PictureBox GameOver;
        private System.Windows.Forms.PictureBox smoke;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label distanceText;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

