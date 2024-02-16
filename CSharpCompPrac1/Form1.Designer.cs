namespace CSharpCompPrac1
{
    partial class Form1
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
            DataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Vendors = new DataGridViewTextBoxColumn();
            Products = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // DataGridView
            // 
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, Vendors, Products });
            DataGridView.Location = new Point(55, 29);
            DataGridView.Name = "DataGridView";
            DataGridView.Size = new Size(668, 364);
            DataGridView.TabIndex = 0;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Vendors
            // 
            Vendors.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Vendors.HeaderText = "Vendors";
            Vendors.Name = "Vendors";
            Vendors.ReadOnly = true;
            // 
            // Products
            // 
            Products.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Products.HeaderText = "Products";
            Products.Name = "Products";
            Products.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DataGridView);
            Name = "Form1";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Vendors;
        private DataGridViewTextBoxColumn Products;
    }
}