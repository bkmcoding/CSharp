using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Json.Net;

namespace JsonFileApp
{
    public partial class ViewJSON : Form
    {
        public ViewJSON()
        {
            InitializeComponent();
            LoadJson();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadJson();
        }

        public static void LoadJson()
        {
            using StreamReader dataFile = new StreamReader("test.json");
            List<string[]> dataList = [];
            while (!dataFile.EndOfStream)
            {
                string[]? Pair = null;
                var line = dataFile.ReadLine();
                line = line.Replace("{", string.Empty);
                line = line.Replace("}", string.Empty);
                line = line.Replace("\"", string.Empty);
                line = line.Replace(",", string.Empty);
                line = line.Replace(" ", string.Empty);
                if (line != string.Empty)
                {
                    Pair = line?.Split(":");
                }
                if (Pair != null)
                {
                    dataList.Add(Pair);
                }
            }


            int j = 0;
            for (double i = 0; i < dataList.Count / 3; i += 0.34)
            {
                if (j % 3 == 0)
                {
                    dgvJsonData.Rows.Add();
                }
                dgvJsonData.Rows[Convert.ToInt32(Math.Floor(i))].Cells[j % 3].Value =
                    dataList[j][1];  
                
                j++;
            }
            
        }
    }
}
