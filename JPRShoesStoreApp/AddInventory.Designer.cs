namespace JPRShoesStoreApp
{
    partial class AddInventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            InventoryItemBox = new ComboBox();
            AddItemButton = new Button();
            ExitButton = new Button();
            InventoryItemLabel = new Label();
            ItemQuantityLabel = new Label();
            ItemQuantity = new TextBox();
            SuspendLayout();
            // 
            // InventoryItemBox
            // 
            InventoryItemBox.BackColor = Color.White;
            InventoryItemBox.DropDownStyle = ComboBoxStyle.DropDownList;
            InventoryItemBox.FormattingEnabled = true;
            InventoryItemBox.Location = new Point(76, 94);
            InventoryItemBox.Name = "InventoryItemBox";
            InventoryItemBox.Size = new Size(235, 23);
            InventoryItemBox.TabIndex = 0;
            // 
            // AddItemButton
            // 
            AddItemButton.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddItemButton.Location = new Point(52, 269);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(285, 48);
            AddItemButton.TabIndex = 1;
            AddItemButton.Text = "Add Item";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExitButton.Location = new Point(52, 347);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(285, 44);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // InventoryItemLabel
            // 
            InventoryItemLabel.AutoSize = true;
            InventoryItemLabel.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InventoryItemLabel.Location = new Point(76, 58);
            InventoryItemLabel.Name = "InventoryItemLabel";
            InventoryItemLabel.Size = new Size(135, 23);
            InventoryItemLabel.TabIndex = 3;
            InventoryItemLabel.Text = "Inventory Item";
            // 
            // ItemQuantityLabel
            // 
            ItemQuantityLabel.AutoSize = true;
            ItemQuantityLabel.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ItemQuantityLabel.Location = new Point(76, 156);
            ItemQuantityLabel.Name = "ItemQuantityLabel";
            ItemQuantityLabel.Size = new Size(125, 23);
            ItemQuantityLabel.TabIndex = 4;
            ItemQuantityLabel.Text = "Item Quantity";
            // 
            // ItemQuantity
            // 
            ItemQuantity.Location = new Point(76, 191);
            ItemQuantity.Name = "ItemQuantity";
            ItemQuantity.Size = new Size(235, 23);
            ItemQuantity.TabIndex = 5;
            // 
            // AddInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 450);
            Controls.Add(ItemQuantity);
            Controls.Add(ItemQuantityLabel);
            Controls.Add(InventoryItemLabel);
            Controls.Add(ExitButton);
            Controls.Add(AddItemButton);
            Controls.Add(InventoryItemBox);
            Name = "AddInventory";
            Text = "Add Inventory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox InventoryItemBox;
        private Button AddItemButton;
        private Button ExitButton;
        private Label InventoryItemLabel;
        private Label ItemQuantityLabel;
        private TextBox ItemQuantity;
    }
}