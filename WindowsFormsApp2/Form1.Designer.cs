
namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.gameOverText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.pbOn = new System.Windows.Forms.PictureBox();
            this.pbOff = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOff)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Transparent;
            this.scoreText.Font = new System.Drawing.Font("Freshman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.ForeColor = System.Drawing.Color.Transparent;
            this.scoreText.Location = new System.Drawing.Point(338, 46);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(38, 33);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "0";
            this.scoreText.Click += new System.EventHandler(this.label1_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // gameOverText
            // 
            this.gameOverText.AutoSize = true;
            this.gameOverText.Font = new System.Drawing.Font("Freshman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gameOverText.Location = new System.Drawing.Point(247, 261);
            this.gameOverText.Name = "gameOverText";
            this.gameOverText.Size = new System.Drawing.Size(0, 33);
            this.gameOverText.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.restart;
            this.pictureBox1.Location = new System.Drawing.Point(331, 306);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ground
            // 
            this.ground.Image = global::WindowsFormsApp2.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-130, 597);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1752, 112);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = global::WindowsFormsApp2.Properties.Resources.pipe1;
            this.pipeBottom.Location = new System.Drawing.Point(358, 386);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(89, 223);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 2;
            this.pipeBottom.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.Image = global::WindowsFormsApp2.Properties.Resources.bird;
            this.flappyBird.Location = new System.Drawing.Point(12, 246);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(60, 48);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 1;
            this.flappyBird.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::WindowsFormsApp2.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(519, -11);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(89, 223);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 0;
            this.pipeTop.TabStop = false;
            // 
            // pbOn
            // 
            this.pbOn.Image = ((System.Drawing.Image)(resources.GetObject("pbOn.Image")));
            this.pbOn.Location = new System.Drawing.Point(29, 28);
            this.pbOn.Name = "pbOn";
            this.pbOn.Size = new System.Drawing.Size(43, 43);
            this.pbOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOn.TabIndex = 7;
            this.pbOn.TabStop = false;
            this.pbOn.Click += new System.EventHandler(this.pbOn_Click);
            // 
            // pbOff
            // 
            this.pbOff.Image = ((System.Drawing.Image)(resources.GetObject("pbOff.Image")));
            this.pbOff.Location = new System.Drawing.Point(29, 28);
            this.pbOff.Name = "pbOff";
            this.pbOff.Size = new System.Drawing.Size(43, 43);
            this.pbOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOff.TabIndex = 8;
            this.pbOff.TabStop = false;
            this.pbOff.Visible = false;
            this.pbOff.Click += new System.EventHandler(this.pbOff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(728, 699);
            this.Controls.Add(this.pbOff);
            this.Controls.Add(this.pbOn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gameOverText);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.pipeTop);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label gameOverText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbOn;
        private System.Windows.Forms.PictureBox pbOff;
    }
}

