namespace flappyBird
{
    partial class FlappyBirdClone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlappyBirdClone));
            flappyBird = new PictureBox();
            pipeTop = new PictureBox();
            pipeBottom = new PictureBox();
            ground = new PictureBox();
            scoreText = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)flappyBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            SuspendLayout();
            // 
            // flappyBird
            // 
            flappyBird.BackColor = Color.LightSkyBlue;
            flappyBird.BackgroundImageLayout = ImageLayout.None;
            flappyBird.Image = (Image)resources.GetObject("flappyBird.Image");
            flappyBird.Location = new Point(50, 150);
            flappyBird.Name = "flappyBird";
            flappyBird.Size = new Size(30, 20);
            flappyBird.SizeMode = PictureBoxSizeMode.StretchImage;
            flappyBird.TabIndex = 0;
            flappyBird.TabStop = false;
            // 
            // pipeTop
            // 
            pipeTop.BackColor = Color.Transparent;
            pipeTop.BackgroundImage = (Image)resources.GetObject("pipeTop.BackgroundImage");
            pipeTop.BackgroundImageLayout = ImageLayout.None;
            pipeTop.Image = (Image)resources.GetObject("pipeTop.Image");
            pipeTop.Location = new Point(400, 2);
            pipeTop.Name = "pipeTop";
            pipeTop.Size = new Size(48, 156);
            pipeTop.TabIndex = 1;
            pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            pipeBottom.BackColor = Color.Transparent;
            pipeBottom.BackgroundImage = (Image)resources.GetObject("pipeBottom.BackgroundImage");
            pipeBottom.BackgroundImageLayout = ImageLayout.None;
            pipeBottom.BorderStyle = BorderStyle.Fixed3D;
            pipeBottom.Location = new Point(400, 256);
            pipeBottom.Name = "pipeBottom";
            pipeBottom.Size = new Size(48, 150);
            pipeBottom.SizeMode = PictureBoxSizeMode.Zoom;
            pipeBottom.TabIndex = 2;
            pipeBottom.TabStop = false;
            // 
            // ground
            // 
            ground.BackColor = Color.SaddleBrown;
            ground.BackgroundImage = (Image)resources.GetObject("ground.BackgroundImage");
            ground.BackgroundImageLayout = ImageLayout.Stretch;
            ground.Dock = DockStyle.Bottom;
            ground.Location = new Point(0, 403);
            ground.Name = "ground";
            ground.Size = new Size(782, 50);
            ground.SizeMode = PictureBoxSizeMode.CenterImage;
            ground.TabIndex = 3;
            ground.TabStop = false;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.BackColor = Color.Transparent;
            scoreText.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            scoreText.ForeColor = Color.White;
            scoreText.Location = new Point(10, 20);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(121, 38);
            scoreText.TabIndex = 4;
            scoreText.Text = "Score: 0";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // FlappyBirdClone
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(782, 453);
            Controls.Add(scoreText);
            Controls.Add(ground);
            Controls.Add(pipeBottom);
            Controls.Add(pipeTop);
            Controls.Add(flappyBird);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Name = "FlappyBirdClone";
            Text = " ";
            Load += FlappyBirdClone_Load;
            KeyDown += gameKeyDown;
            KeyUp += gameKeyUp;
            Resize += Form1_Resize;
            ((System.ComponentModel.ISupportInitialize)flappyBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox flappyBird;
        private PictureBox pipeTop;
        private PictureBox pipeBottom;
        private PictureBox ground;
        private Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}
