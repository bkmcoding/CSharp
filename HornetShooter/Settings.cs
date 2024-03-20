using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_MoleShooterApp
{
    public partial class Settings : UserControl
    {
        private int ShootTimeMS = 500;
        private int MissLimitNum = 500;
        private int TimeLimitS = 0;
        public Settings()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            while (true)
            {
                try
                {
                    ShootTimeMS = Convert.ToInt32(ShootTime.Text);
                    MissLimitNum = Convert.ToInt32(MissLimit.Text);
                    TimeLimitS = Convert.ToInt32(TimeLimit.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("User Error", "Please enter a valid input for the settings");
                }
            }
        }
    }
}
