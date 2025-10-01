namespace flappyBird
{
    public partial class FlappyBirdClone : Form
    {
        int pipeSpeed = 4;
        int gravity = 2;      // Constant downward force
        int score = 0;
        int jumpStrength = -8; // Upward force when jumping

        public FlappyBirdClone()
        {
            InitializeComponent();
            this.KeyPreview = true; // Ensure form receives key events
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            // Apply gravity to bird's position
            flappyBird.Top += gravity;

            // Move pipes
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;

            scoreText.Text = "Score: " + score;

            // Reset pipes when they go off screen
            if (pipeBottom.Left < -150)
            {
                pipeBottom.Left = 800;
                score++;
            }

            if (pipeTop.Left < -180)
            {
                pipeTop.Left = 950;
                score++;
            }

            // Collision detection
            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) ||
                flappyBird.Top < -25)
            {
                endGame();
            }

            // Increase speed as score gets higher
            if (score > 5)
                pipeSpeed = 12;
        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                // Jump when space is pressed
                gravity = jumpStrength;
            }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                // Return to normal gravity when space is released
                gravity = 5;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += "  Game Over!!!";

            DialogResult result = MessageBox.Show(
                "Skorun: " + score + "\nYeniden oynamak ister misin?",
                "Oyun Bitti",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                RestartGame();
            }
            else
            {
                // Oyunu kapatabilir veya bekletebilirsin
                this.Close();
                // veya sadece geri d�n�p oyuncunun ��kmas�n� bekle:
                // return;
            }
        }
  

        private void FlappyBirdClone_Load(object sender, EventArgs e)
        {
            // Focus the form to ensure it receives key events
            this.Focus();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // Form boyutlar�na g�re konumlar� ayarla
            ground.Top = this.ClientSize.Height - ground.Height;
            flappyBird.Left = this.ClientSize.Width / 4;

            int gap = (int)(this.ClientSize.Height * 0.25); // ekran�n %25'i kadar bo�luk
            int pipeX = (int)(this.ClientSize.Width * 0.7); // borular�n soldan uzakl���

            // �st boru
            pipeTop.Left = pipeX;
            pipeTop.Top = 0;

            // Alt boru
            pipeBottom.Left = pipeX;
            pipeBottom.Top = pipeTop.Height + gap;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
        private void RestartGame()
        {
            // skor s�f�rla
            score = 0;
            scoreText.Text = "Score: 0";

            // nesneleri ba�lang�� konumuna d�nd�r
            flappyBird.Top = 200;
            flappyBird.Left = 100;

            pipeTop.Left = 800;
            pipeBottom.Left = 800;

            // h�zlar� s�f�rla
            pipeSpeed = 4;
            gravity = 2;

            // butonu gizle
            btnRestart.Visible = false;

            // timer�� tekrar ba�lat
            gameTimer.Start();
        }

    }
}