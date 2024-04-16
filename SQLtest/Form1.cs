using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SQLtest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveButton_click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=PC15;Initial Catalog=Phonebook;Integrated Security=True;Encrypt=false";

            string sqlQuery = "INSERT INTO RECORD (FirstName, LastName, PhoneNumber) VALUES (" + "'" + txtFirstName.Text + "'" + "," + "'" + txtLastName.Text + "'" + "," + "'" + txtPhoneNumber.Text + "'" + ");";

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();
            SqlCommand sc = new SqlCommand(sqlQuery, con);
            sc.ExecuteNonQuery();
            con.Close();

        }
    }
}
