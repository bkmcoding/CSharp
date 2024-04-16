using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JsonFileApp
{
    public partial class Form1 : Form
    {
        public ViewJSON DataForm { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
        public Form1()
        {
            InitializeComponent();
            DataForm = new ViewJSON();
            DataForm.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            bool error = false;
            try
            {
                FName = txtFName.Text;
                LName = txtLName.Text;
                Age = Convert.ToInt32(txtAge.Text);
            }
            catch (Exception)
            {
                error = true;
                MessageBox.Show("Please enter proper data into the fields", "Error Message");
            }
            finally
            {
                if (!error)
                {
                    List<data> _data = new List<data>();
                    _data.Add(new data()
                    {
                        fname = FName,
                        lname = LName,
                        age = Age
                    });

                    string json = JsonSerializer.Serialize(_data);
                    File.WriteAllText("test.json", json);
                }
                
            }
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            DataForm.Show();
        }
    }

    public class data
    {
        public string fname { get; set; }
        public string lname { get; set; }
        public int age { get; set; }
    }
}
