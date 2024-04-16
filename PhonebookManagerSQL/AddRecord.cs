using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhonebookManagerSQL
{
    public partial class AddRecord : Form
    {
        public AddRecord()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            const string eTitle = "Error Message";
            string eMessage = "";
            string FirstName = null;
            string LastName = null;
            string PhoneNumber = null;
            bool error = false;
            try
            {
                FirstName = txtFirstName.Text;
                LastName = txtLastName.Text;
                PhoneNumber = txtPhoneNumber.Text;
                if (Regex.Match(txtPhoneNumber.Text, @"^\d{10}$").Success)
                {
                }
                else
                {
                    throw new Exception("Invalid Phone Number");
                }
                
            }
            catch (Exception)
            {
                error = true;
                if (FirstName == null)
                {
                    eMessage += "Please type a valid First Name \n";
                }
                else if(LastName == null)
                {
                    eMessage += "Please type a valid Last Name \n";
                } 
                else
                {
                    eMessage += "Please type a valid Phone Number \n";
                }
            }
            finally
            {
                if (!error)
                {
                    string connectionString = "Data Source=PC15;Initial Catalog=Phonebook;Integrated Security=True;Encrypt=false";

                    string sqlQuery = "INSERT INTO RECORD (FirstName, LastName, PhoneNumber) VALUES (" + "'" + FirstName + "'" + "," + "'" + LastName + "'" + "," + "'" + PhoneNumber + "'" + ");";

                    SqlConnection con = new SqlConnection(connectionString);

                    con.Open();
                    SqlCommand sc = new SqlCommand(sqlQuery, con);
                    sc.ExecuteNonQuery();
                    con.Close();
                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                    txtPhoneNumber.Text = "";
                }
                else
                {
                    MessageBox.Show(eTitle, eMessage);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
