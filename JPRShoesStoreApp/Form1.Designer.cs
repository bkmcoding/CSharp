namespace JPRShoesStoreApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainLabel = new Label();
            InventoryGridView = new DataGridView();
            UPC = new DataGridViewTextBoxColumn();
            ItemDesc = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            ListPrice = new DataGridViewTextBoxColumn();
            RetailPrice = new DataGridViewTextBoxColumn();
            ModifyInventoryButton = new Button();
            RefreshInventoryButton = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)InventoryGridView).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // MainLabel
            // 
            MainLabel.AutoSize = true;
            MainLabel.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainLabel.Location = new Point(48, 37);
            MainLabel.Name = "MainLabel";
            MainLabel.Size = new Size(265, 78);
            MainLabel.TabIndex = 0;
            MainLabel.Text = "JPR Accounting\r\n\r\n";
            // 
            // InventoryGridView
            // 
            InventoryGridView.AllowUserToAddRows = false;
            InventoryGridView.AllowUserToDeleteRows = false;
            InventoryGridView.BackgroundColor = SystemColors.ButtonHighlight;
            InventoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InventoryGridView.Columns.AddRange(new DataGridViewColumn[] { UPC, ItemDesc, Quantity, ListPrice, RetailPrice });
            InventoryGridView.Location = new Point(48, 99);
            InventoryGridView.Name = "InventoryGridView";
            InventoryGridView.ReadOnly = true;
            InventoryGridView.Size = new Size(700, 225);
            InventoryGridView.TabIndex = 1;
            // 
            // UPC
            // 
            UPC.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UPC.HeaderText = "UPC(10-Digit)";
            UPC.Name = "UPC";
            UPC.ReadOnly = true;
            // 
            // ItemDesc
            // 
            ItemDesc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ItemDesc.HeaderText = "Item Description";
            ItemDesc.Name = "ItemDesc";
            ItemDesc.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // ListPrice
            // 
            ListPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ListPrice.HeaderText = "List Price";
            ListPrice.Name = "ListPrice";
            ListPrice.ReadOnly = true;
            // 
            // RetailPrice
            // 
            RetailPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RetailPrice.HeaderText = "Retail Price";
            RetailPrice.Name = "RetailPrice";
            RetailPrice.ReadOnly = true;
            // 
            // ModifyInventoryButton
            // 
            ModifyInventoryButton.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ModifyInventoryButton.Location = new Point(57, 347);
            ModifyInventoryButton.Name = "ModifyInventoryButton";
            ModifyInventoryButton.Size = new Size(269, 79);
            ModifyInventoryButton.TabIndex = 2;
            ModifyInventoryButton.Text = "Modify Inventory";
            ModifyInventoryButton.UseVisualStyleBackColor = true;
            ModifyInventoryButton.Click += AddInventoryButton_Click;
            // 
            // RefreshInventoryButton
            // 
            RefreshInventoryButton.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RefreshInventoryButton.Location = new Point(446, 347);
            RefreshInventoryButton.Name = "RefreshInventoryButton";
            RefreshInventoryButton.Size = new Size(269, 79);
            RefreshInventoryButton.TabIndex = 3;
            RefreshInventoryButton.Text = "Refresh Inventory";
            RefreshInventoryButton.UseVisualStyleBackColor = true;
            RefreshInventoryButton.Click += RefreshInventoryButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RefreshInventoryButton);
            Controls.Add(ModifyInventoryButton);
            Controls.Add(InventoryGridView);
            Controls.Add(MainLabel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "JPRAccounting";
            ((System.ComponentModel.ISupportInitialize)InventoryGridView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MainLabel;
        private DataGridView InventoryGridView;
        private Button ModifyInventoryButton;
        private Button RefreshInventoryButton;
        private DataGridViewTextBoxColumn UPC;
        private DataGridViewTextBoxColumn ItemDesc;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn ListPrice;
        private DataGridViewTextBoxColumn RetailPrice;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
    }
}
