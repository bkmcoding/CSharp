using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhonebookManagerSQL
{
    public partial class RemoveRecord : Form
    {
        public RemoveRecord()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            const string eTitle = "Error Message";
            string eMessage = "Please enter a valid ID to remove from the DATABASE";
            int ID = 0;
            bool error = false;
            try
            {
                ID = Convert.ToInt32(txtID.Text);
            }
            catch (Exception)
            {
                error = true;
            }
            finally
            {
                if (!error)
                {
                    string connectionString = "Data Source=PC15;Initial Catalog=Phonebook;Integrated Security=True;Encrypt=false";

                    string sqlQuery = "DELETE FROM RECORD WHERE ID = '" + ID + "';";

                    SqlConnection con = new SqlConnection(connectionString);

                    con.Open();
                    SqlCommand sc = new SqlCommand(sqlQuery, con);
                    sc.CommandText = sqlQuery;
                    if (sc.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("DATA DELETED SUCCESSFULLY");
                    }
                    else
                    {
                        MessageBox.Show("DATA NOT DELETED SUCCESSFULLY");
                    }
                    con.Close();
                    txtID.Text = "";
                }
                else
                {
                    MessageBox.Show(eTitle, eMessage);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
