using System.Data.OleDb;
using System.Drawing.Text;

namespace TypeSpeedTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("RobotoMono.ttf");
            label1.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
            foreach (Control c in this.Controls)
            {
                float oldFont = c.Font.Size;
                System.Drawing.FontStyle oldFontStyle = c.Font.Style;
                c.Font = new Font(pfc.Families[0], oldFont, oldFontStyle);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
