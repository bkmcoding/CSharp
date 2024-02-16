using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace JPRShoesStoreApp
{
    public partial class AddInventory : Form
    {
        public List<string[]> InventoryChange { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public AddInventory()
        {
            InventoryChange = new List<string[]>();
            InitializeComponent();
            this.ControlBox = false;
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            const string eTitle = "Input Error";
            var eMessage = "";
            bool[] errors = [false, false];
            try
            {
                ItemName = InventoryItemBox.GetItemText(InventoryItemBox.SelectedItem);
                if (ItemName is "")
                {
                    errors[0] = true;
                }
            }
            catch (Exception)
            {
                errors[0] = true;
            }
            try
            {
                Quantity = Convert.ToInt32(ItemQuantity.Text);
            }
            catch (Exception)
            {
                errors[1] = true;
            }

            var error = false;
            if (errors[0])
            {
                eMessage += "Please select a inventory item \n";
                error = true;
            }
            if (errors[1])
            {
                eMessage += "Please input a valid amount of inventory items";
                error = true;
            }
            if (error)
            {
                MessageBox.Show(eMessage, eTitle);
            }
            else
            {
                string[] pair =
                [
                    ItemName,
                    Quantity.ToString()
                ];
                InventoryChange.Add(pair);
            }
        }

        public void GetInventoryItems(Dictionary<string, Item>.KeyCollection inventoryNames)
        {
            InventoryItemBox.Items.Clear();
            foreach (var itemName in inventoryNames)
            {
                InventoryItemBox.Items.Add(itemName);
            }

        }

    }
}
