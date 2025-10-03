namespace Classsic_Snake
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            startButton = new System.Windows.Forms.Button();
            snapButton = new System.Windows.Forms.Button();
            picCanvas = new System.Windows.Forms.PictureBox();
            txtScore = new System.Windows.Forms.Label();
            txtHighScore = new System.Windows.Forms.Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.BackColor = System.Drawing.SystemColors.HotTrack;
            startButton.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            startButton.Location = new System.Drawing.Point(598, 12);
            startButton.Name = "startButton";
            startButton.Size = new System.Drawing.Size(115, 59);
            startButton.TabIndex = 0;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += StartGame;
            // 
            // snapButton
            // 
            snapButton.BackColor = System.Drawing.SystemColors.HotTrack;
            snapButton.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            snapButton.Location = new System.Drawing.Point(598, 77);
            snapButton.Name = "snapButton";
            snapButton.Size = new System.Drawing.Size(115, 56);
            snapButton.TabIndex = 1;
            snapButton.Text = "Snap";
            snapButton.UseVisualStyleBackColor = false;
            snapButton.Click += TakeSnapShot;
            // 
            // picCanvas
            // 
            picCanvas.BackColor = System.Drawing.Color.Silver;
            picCanvas.Location = new System.Drawing.Point(12, 12);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new System.Drawing.Size(580, 680);
            picCanvas.TabIndex = 2;
            picCanvas.TabStop = false;
            picCanvas.Paint += UpdatePictureBoxGraphics;
            // 
            // txtScore
            // 
            txtScore.AutoSize = true;
            txtScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtScore.Location = new System.Drawing.Point(598, 157);
            txtScore.Name = "txtScore";
            txtScore.Size = new System.Drawing.Size(69, 21);
            txtScore.TabIndex = 3;
            txtScore.Text = "Score: 0";
            // 
            // txtHighScore
            // 
            txtHighScore.AutoSize = true;
            txtHighScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtHighScore.Location = new System.Drawing.Point(598, 225);
            txtHighScore.Name = "txtHighScore";
            txtHighScore.Size = new System.Drawing.Size(97, 21);
            txtHighScore.TabIndex = 4;
            txtHighScore.Text = "High Score:";
            // 
            // gameTimer
            // 
            gameTimer.Interval = 60;
            gameTimer.Tick += GameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(748, 725);
            Controls.Add(txtHighScore);
            Controls.Add(txtScore);
            Controls.Add(picCanvas);
            Controls.Add(snapButton);
            Controls.Add(startButton);
            Name = "Form1";
            Text = "Classsic Snake Game";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button snapButton;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtHighScore;
        private System.Windows.Forms.Timer gameTimer;
    }
}
