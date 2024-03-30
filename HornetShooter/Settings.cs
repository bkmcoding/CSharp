using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HornetShooter
{

    public partial class SettingsMenu : UserControl
    {
        public int ShootTimeMs { get; private set; } = 500;
        public int MissLimitNum { get; private set; } = 10;
        public int TimeLimitS { get; private set; } = 0;
        public int TargetSizePx { get; private set; } = 60;
        public SettingsMenu()
        {
            InitializeComponent();
            ShootTime.Text = ShootTimeMs.ToString();
            MissLimit.Text = MissLimitNum.ToString();
            TimeLimit.Text = TimeLimitS.ToString();
            TargetSize.Text = TargetSizePx.ToString();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            bool error = false;
            try
            {
                ShootTimeMs = Convert.ToInt32(ShootTime.Text);
                MissLimitNum = Convert.ToInt32(MissLimit.Text);
                TimeLimitS = Convert.ToInt32(TimeLimit.Text);
                TargetSizePx = Convert.ToInt32(TargetSize.Text);
            }
            catch (Exception)
            {
                error = true;
                MessageBox.Show("User Error", "Please enter a valid input for the settings");
            }

            if (!error)
            {
                ShootTime.Text = ShootTimeMs.ToString();
                MissLimit.Text = MissLimitNum.ToString();
                TimeLimit.Text = TimeLimitS.ToString();
                TargetSize.Text = TargetSizePx.ToString();
            }

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
