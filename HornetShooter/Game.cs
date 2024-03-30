using System.Media;

namespace HornetShooter
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private Random r = new Random();
        private int Score = 0;
        private int TotalShots = 0;
        private int MissShots = 0;
        private bool TimerActive = true;

        private void sound_fx(string soundEffect)
        {
            SoundPlayer? player = null;
            if (soundEffect == "shot")
            {
                player = new System.Media.SoundPlayer(@"G:\Downloads\laser.wav");

            }

            if (player != null) player.Play();
        }

        private void fn_shot()
        {
            Score += 9876;
            ScoreLabel.Text = "Score=" + Score;
            TotalShots++;
            TotalShotLabel.Text = "Total Shots=" + TotalShots;

            sound_fx("shot");
        }

        private void fn_miss_shot()
        {
            TotalShots++;
            TotalShotLabel.Text = "Total Shots=" + TotalShots;
            MissShots++;
            MissShotLabel.Text = "Miss Shots=" + MissShots;

            sound_fx("shot");
        }

        void reset()
        {
            Score = 0;
            TotalShots = 0;
            MissShots = 0;
            ScoreLabel.Text = "Score=" + Score;
            TotalShotLabel.Text = "Total Shots=" + TotalShots;
            MissShotLabel.Text = "Miss Shots=" + MissShots;
            GameOverLabel.Text = "";
            Timer.Start();
            TimerActive = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int x, y;
            x = r.Next(200, 650);
            y = r.Next(50, 250);
            Enemy.Location = new Point(x, y);
            if (MissShots > 10)
            {
                Timer.Stop();
                TimerActive = false;
                GameOverLabel.Text = "Game Over";
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void Enemy_MouseDown(object sender, MouseEventArgs e)
        {
            if (TimerActive)
            {
                fn_shot();
            }
        }

        private void Game_MouseDown(object sender, MouseEventArgs e)
        {
            if (TimerActive)
            {
                fn_miss_shot();
            }
        }
    }
}
