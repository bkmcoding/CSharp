using System.Drawing.Drawing2D;

namespace BankingSystemApp
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
            CustomerListView.Items[0].BackColor = Color.Yellow;
        }


        private void NavCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
