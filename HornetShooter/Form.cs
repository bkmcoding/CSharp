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
    public partial class Form : System.Windows.Forms.Form
    {
        private Menu menu;
        
        public Form()
        {
            InitializeComponent();
            menu = new Menu();
            this.Controls.Add(menu);
            menu.Show();
        }

    }
}
