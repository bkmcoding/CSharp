using System.Diagnostics;
using System.Drawing.Imaging;
using System.Formats.Asn1;
using System.Globalization;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace JPRShoesStoreApp
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public ModifyInventoryForm Add { get; set; }
        public Dictionary<string, Item> Inventory { get; set; }

        private string? FileName { get; set; } = null;

        public Form1()
        {
            InitializeComponent();
            Inventory = new Dictionary<string, Item>();
            Add = new ModifyInventoryForm();
            Add.Hide();
        }

        private void AddInventoryButton_Click(object sender, EventArgs e)
        {
            Add.Show();
        }

        private void RefreshInventoryButton_Click(object sender, EventArgs e)
        {
            InventoryGridView.Rows.Clear();
            foreach (var pair in Add.InventoryChange)
            {
                foreach (var item in Inventory)
                {
                    if (pair[0] == item.Key)
                    {
                        item.Value.Update(Convert.ToInt32(pair[1]));
                    }
                }
            }

            Add.InventoryChange = [];
            this.LoadInventory();
        }

        private void LoadInventory()
        {
            var i = 0;
            var j = 0;
            foreach (var pair in Inventory)
            {
                InventoryGridView.Rows.Add();
                var itemData = pair.Value.GetProperties();
                foreach (var data in itemData)
                {
                    InventoryGridView.Rows[i].Cells[j].Value = itemData[j];
                    j++;
                }
                j = 0;
                i++;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileExplorer = new OpenFileDialog
            {
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = @"csv files (*.csv)|*.csv",
                FilterIndex = 2,
                RestoreDirectory = true,
            };
            fileExplorer.ShowDialog();
            if (!fileExplorer.CheckFileExists) return;
            Inventory.Clear();
            FileName = fileExplorer.FileName;
            using StreamReader dataFile = new StreamReader(fileExplorer.FileName);
            List<string[]> dataList = [];
            while (!dataFile.EndOfStream)
            {
                var line = dataFile.ReadLine();
                var values = line?.Split(",");
                if (values != null) dataList.Add(values);
            }
            foreach (var row in dataList)
            {
                string keyName = row[1];
                Inventory.Add(keyName, new Item(Convert.ToInt64(row[0]), row[1], Convert.ToInt64(row[2]), Convert.ToDouble(row[3])));
            }

            InventoryGridView.Rows.Clear();
            this.LoadInventory();
            Add.GetInventoryItems(Inventory.Keys);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileName == null)
            {
                MessageBox.Show("No file is opened", "File Error");
            }
            else
            {
                StringBuilder csvData = new StringBuilder();
                const string separator = ",";
                foreach (var item in Inventory)
                {
                    string[] prop = item.Value.GetProperties();
                    List<string> itemData = [];
                    for (int i = 0; i < prop.Length - 1; i++)
                    {
                        itemData.Add(prop[i]);
                    }

                    csvData.AppendLine(string.Join(separator, itemData));
                }
                File.WriteAllText(FileName, csvData.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
