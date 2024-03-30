using System.DirectoryServices.ActiveDirectory;
using System.Media;

namespace HornetShooter
{
    public partial class Game : System.Windows.Forms.Form
    {
        public int MissLimit { get; }
        public int TimeLimit { get; }
        public int CurrentTime { get; set; }

        public Game(int shootTime, int missLimit, int timeLimit, int targetSize)
        {
            InitializeComponent();
            Enemy.Padding = new Padding(0);
            Enemy.Size = new System.Drawing.Size(targetSize, targetSize);
            GameInterval.Interval = shootTime;
            this.MissLimit = missLimit;
            this.TimeLimit = timeLimit;
            if (TimeLimit == 0)
            {
                Timer.Enabled = false;
            }
            else
            {
                Timer.Enabled = true;
            }
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
            GameInterval.Start();
            TimerActive = true;
        }

        private void Game_Interval_Tick(object sender, EventArgs e)
        {
            int x, y;
            x = r.Next(200, 650);
            y = r.Next(50, 250);
            Enemy.Location = new Point(x, y);
            if (MissShots >= this.MissLimit)
            {
                GameInterval.Stop();
                TimerActive = false;
                GameOverLabel.Text = "Game Over";
                CurrentTimeLabel.Text = "";
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            CurrentTime += 1;
            char Second = CurrentTime.ToString()[CurrentTime.ToString().Length];
            decimal TenSeconds = Math.Floor((decimal)(CurrentTime / 60));
            decimal Minutes = Math.Floor((decimal)(CurrentTime / 60));
            decimal TenMinutes = Math.Floor(Minutes / 10);

            CurrentTimeLabel.Text = TenMinutes + Minutes + ":" + TenSeconds + Second;

            if (CurrentTime >= TimeLimit)
            {
                GameInterval.Stop();
                TimerActive = false;
                GameOverLabel.Text = "Game Over";
                CurrentTimeLabel.Text = "";
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form? tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();
            this.Close();
            this.Dispose();
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
