using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace PhonebookManagerSQL
{
    public partial class PBManagerForm : Form
    {
        public AddRecord Add { get; set; }

        public RemoveRecord Remove { get; set; }
        public PBManagerForm()
        {
            InitializeComponent();
            Add = new AddRecord();
            Remove = new RemoveRecord();
            Add.Hide();
            Remove.Hide();
            ControlBox = false;
        }

        private SqlConnection con;
        private SqlCommand cmd;

        private void RefreshDGV()
        {
            con = new SqlConnection("data source=PC15;initial catalog=Phonebook;integrated security=True;Encrypt=false;");
            cmd = new SqlCommand("select * from Record", con);
            string selectquery = "select * from Record";
            SqlDataAdapter adpt = new SqlDataAdapter(selectquery, con);
            DataTable table = new DataTable();
            adpt.Fill(table);
            dgvRecordList.DataSource = table;
            for (int i = 0; i <= dgvRecordList.Columns.Count - 1; i++)
            {
                dgvRecordList.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void PBManagerForm_Load(object sender, EventArgs e)
        {
            RefreshDGV();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDGV();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Remove.Show();
        }
    }
}
