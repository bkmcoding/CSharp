using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSharpCompPrac1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            StreamReader vendorFile = new StreamReader(File.OpenRead("Vendor.csv"));
            StreamReader productFile = new StreamReader(File.OpenRead("products.csv"));
            List<string[]> vendorsList = readCSV(vendorFile);
            List<string[]> productList = readCSV(productFile);
            for (int i = 0; i < vendorsList.Count; i++)
            {
                DataGridView.Rows.Add();
                for (int j = 0; j < vendorsList[i].Length; j++)
                {
                    DataGridView.Rows[i].Cells[j].Value = vendorsList[i][j];
                }
                string concat = "";
                for (int j = 1; j < productList[i].Length; j++)
                {
                    concat += productList[i][j] + ", ";
                }
                DataGridView.Rows[i].Cells[2].Value = concat;

                
            }
            static List<string[]> readCSV(StreamReader file)
            {
                List<string[]> DataList = [];
                while (!file.EndOfStream)
                {
                    var line = file.ReadLine();
                    var values = line?.Split(",");
                    if (values != null) DataList.Add(values);
                }

                return DataList;
            }
        }
    }
}
