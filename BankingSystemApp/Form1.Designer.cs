namespace BankingSystemApp
{
    partial class CustomersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersForm));
            ListViewItem listViewItem1 = new ListViewItem("YessouFou Abdel");
            BorderPanel = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            AccountDetailsGroupBox = new GroupBox();
            DateOpenedInput = new TextBox();
            label9 = new Label();
            AccessCodeInput = new TextBox();
            AccountNoLabel = new Label();
            BalanceInput = new TextBox();
            label10 = new Label();
            AccountTypeInput = new TextBox();
            AccountTypeLabel = new Label();
            ATMCardNoInput = new TextBox();
            DateOpenedLabel = new Label();
            ExpiryDateInput = new TextBox();
            ATMCardNoLabel = new Label();
            AccountNoInput = new TextBox();
            AccessCodeLabel = new Label();
            ExpiryDateLabel = new Label();
            BalanceLabel = new Label();
            NavRowPanel = new Panel();
            NavCloseButton = new Button();
            NavSearchButton = new Button();
            NavDeleteButton = new Button();
            NavUpdateButton = new Button();
            NavNewButton = new Button();
            PersonalDetailsGroupBox = new GroupBox();
            EmailAddressInput = new TextBox();
            OfficePhoneInput = new TextBox();
            HomePhoneInput = new TextBox();
            GenderInput = new TextBox();
            DOBInput = new TextBox();
            LastNameInput = new TextBox();
            OfficeAddressInput = new TextBox();
            HomeAddressInput = new TextBox();
            FirstNameInput = new TextBox();
            HomePhoneLabel = new Label();
            OfficePhoneLabel = new Label();
            EmailAddessLabel = new Label();
            GenderLabel = new Label();
            DateOfBirthLabel = new Label();
            HomeAddressLabel = new Label();
            OfficeAddressLabel = new Label();
            LastNameLabel = new Label();
            FirstNameLabel = new Label();
            CustomerListPanel = new Panel();
            CustomerListView = new ListView();
            BottomCustomerButton = new Button();
            DownCustomerButton = new Button();
            UpCustomerButton = new Button();
            TopCustomerButton = new Button();
            BorderPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            AccountDetailsGroupBox.SuspendLayout();
            NavRowPanel.SuspendLayout();
            PersonalDetailsGroupBox.SuspendLayout();
            CustomerListPanel.SuspendLayout();
            SuspendLayout();
            // 
            // BorderPanel
            // 
            BorderPanel.BorderStyle = BorderStyle.FixedSingle;
            BorderPanel.Controls.Add(panel1);
            BorderPanel.Controls.Add(AccountDetailsGroupBox);
            BorderPanel.Controls.Add(NavRowPanel);
            BorderPanel.Controls.Add(PersonalDetailsGroupBox);
            BorderPanel.Controls.Add(CustomerListPanel);
            BorderPanel.Location = new Point(2, 3);
            BorderPanel.Name = "BorderPanel";
            BorderPanel.Size = new Size(978, 454);
            BorderPanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(791, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(178, 362);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 194);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // AccountDetailsGroupBox
            // 
            AccountDetailsGroupBox.Controls.Add(DateOpenedInput);
            AccountDetailsGroupBox.Controls.Add(label9);
            AccountDetailsGroupBox.Controls.Add(AccessCodeInput);
            AccountDetailsGroupBox.Controls.Add(AccountNoLabel);
            AccountDetailsGroupBox.Controls.Add(BalanceInput);
            AccountDetailsGroupBox.Controls.Add(label10);
            AccountDetailsGroupBox.Controls.Add(AccountTypeInput);
            AccountDetailsGroupBox.Controls.Add(AccountTypeLabel);
            AccountDetailsGroupBox.Controls.Add(ATMCardNoInput);
            AccountDetailsGroupBox.Controls.Add(DateOpenedLabel);
            AccountDetailsGroupBox.Controls.Add(ExpiryDateInput);
            AccountDetailsGroupBox.Controls.Add(ATMCardNoLabel);
            AccountDetailsGroupBox.Controls.Add(AccountNoInput);
            AccountDetailsGroupBox.Controls.Add(AccessCodeLabel);
            AccountDetailsGroupBox.Controls.Add(ExpiryDateLabel);
            AccountDetailsGroupBox.Controls.Add(BalanceLabel);
            AccountDetailsGroupBox.Location = new Point(522, 9);
            AccountDetailsGroupBox.Name = "AccountDetailsGroupBox";
            AccountDetailsGroupBox.Size = new Size(263, 362);
            AccountDetailsGroupBox.TabIndex = 2;
            AccountDetailsGroupBox.TabStop = false;
            AccountDetailsGroupBox.Text = "Account Details";
            // 
            // DateOpenedInput
            // 
            DateOpenedInput.Location = new Point(97, 251);
            DateOpenedInput.Name = "DateOpenedInput";
            DateOpenedInput.Size = new Size(159, 23);
            DateOpenedInput.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 17;
            // 
            // AccessCodeInput
            // 
            AccessCodeInput.Location = new Point(97, 214);
            AccessCodeInput.Name = "AccessCodeInput";
            AccessCodeInput.Size = new Size(159, 23);
            AccessCodeInput.TabIndex = 23;
            // 
            // AccountNoLabel
            // 
            AccountNoLabel.AutoSize = true;
            AccountNoLabel.Location = new Point(16, 29);
            AccountNoLabel.Name = "AccountNoLabel";
            AccountNoLabel.Size = new Size(71, 15);
            AccountNoLabel.TabIndex = 9;
            AccountNoLabel.Text = "Account No";
            // 
            // BalanceInput
            // 
            BalanceInput.Location = new Point(97, 177);
            BalanceInput.Name = "BalanceInput";
            BalanceInput.Size = new Size(159, 23);
            BalanceInput.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 16;
            // 
            // AccountTypeInput
            // 
            AccountTypeInput.Location = new Point(97, 66);
            AccountTypeInput.Name = "AccountTypeInput";
            AccountTypeInput.Size = new Size(159, 23);
            AccountTypeInput.TabIndex = 21;
            // 
            // AccountTypeLabel
            // 
            AccountTypeLabel.AutoSize = true;
            AccountTypeLabel.Location = new Point(16, 66);
            AccountTypeLabel.Name = "AccountTypeLabel";
            AccountTypeLabel.Size = new Size(79, 15);
            AccountTypeLabel.TabIndex = 10;
            AccountTypeLabel.Text = "Account Type";
            // 
            // ATMCardNoInput
            // 
            ATMCardNoInput.Location = new Point(97, 103);
            ATMCardNoInput.Name = "ATMCardNoInput";
            ATMCardNoInput.Size = new Size(159, 23);
            ATMCardNoInput.TabIndex = 20;
            // 
            // DateOpenedLabel
            // 
            DateOpenedLabel.AutoSize = true;
            DateOpenedLabel.Location = new Point(16, 251);
            DateOpenedLabel.Name = "DateOpenedLabel";
            DateOpenedLabel.Size = new Size(76, 15);
            DateOpenedLabel.TabIndex = 15;
            DateOpenedLabel.Text = "Date Opened";
            // 
            // ExpiryDateInput
            // 
            ExpiryDateInput.Location = new Point(97, 140);
            ExpiryDateInput.Name = "ExpiryDateInput";
            ExpiryDateInput.Size = new Size(159, 23);
            ExpiryDateInput.TabIndex = 19;
            // 
            // ATMCardNoLabel
            // 
            ATMCardNoLabel.AutoSize = true;
            ATMCardNoLabel.Location = new Point(16, 103);
            ATMCardNoLabel.Name = "ATMCardNoLabel";
            ATMCardNoLabel.Size = new Size(78, 15);
            ATMCardNoLabel.TabIndex = 11;
            ATMCardNoLabel.Text = "ATM Card No";
            // 
            // AccountNoInput
            // 
            AccountNoInput.Location = new Point(97, 29);
            AccountNoInput.Name = "AccountNoInput";
            AccountNoInput.Size = new Size(159, 23);
            AccountNoInput.TabIndex = 18;
            // 
            // AccessCodeLabel
            // 
            AccessCodeLabel.AutoSize = true;
            AccessCodeLabel.Location = new Point(16, 214);
            AccessCodeLabel.Name = "AccessCodeLabel";
            AccessCodeLabel.Size = new Size(74, 15);
            AccessCodeLabel.TabIndex = 14;
            AccessCodeLabel.Text = "Access Code";
            // 
            // ExpiryDateLabel
            // 
            ExpiryDateLabel.AutoSize = true;
            ExpiryDateLabel.Location = new Point(16, 140);
            ExpiryDateLabel.Name = "ExpiryDateLabel";
            ExpiryDateLabel.Size = new Size(66, 15);
            ExpiryDateLabel.TabIndex = 12;
            ExpiryDateLabel.Text = "Expiry Date";
            // 
            // BalanceLabel
            // 
            BalanceLabel.AutoSize = true;
            BalanceLabel.Location = new Point(16, 177);
            BalanceLabel.Name = "BalanceLabel";
            BalanceLabel.Size = new Size(48, 15);
            BalanceLabel.TabIndex = 13;
            BalanceLabel.Text = "Balance";
            // 
            // NavRowPanel
            // 
            NavRowPanel.BorderStyle = BorderStyle.FixedSingle;
            NavRowPanel.Controls.Add(NavCloseButton);
            NavRowPanel.Controls.Add(NavSearchButton);
            NavRowPanel.Controls.Add(NavDeleteButton);
            NavRowPanel.Controls.Add(NavUpdateButton);
            NavRowPanel.Controls.Add(NavNewButton);
            NavRowPanel.Location = new Point(259, 385);
            NavRowPanel.Name = "NavRowPanel";
            NavRowPanel.Size = new Size(710, 60);
            NavRowPanel.TabIndex = 2;
            // 
            // NavCloseButton
            // 
            NavCloseButton.Location = new Point(598, 11);
            NavCloseButton.Name = "NavCloseButton";
            NavCloseButton.Size = new Size(102, 39);
            NavCloseButton.TabIndex = 4;
            NavCloseButton.Text = "Close";
            NavCloseButton.UseVisualStyleBackColor = true;
            NavCloseButton.Click += NavCloseButton_Click;
            // 
            // NavSearchButton
            // 
            NavSearchButton.Location = new Point(455, 11);
            NavSearchButton.Name = "NavSearchButton";
            NavSearchButton.Size = new Size(102, 39);
            NavSearchButton.TabIndex = 3;
            NavSearchButton.Text = "Search";
            NavSearchButton.UseVisualStyleBackColor = true;
            // 
            // NavDeleteButton
            // 
            NavDeleteButton.Location = new Point(309, 11);
            NavDeleteButton.Name = "NavDeleteButton";
            NavDeleteButton.Size = new Size(102, 39);
            NavDeleteButton.TabIndex = 2;
            NavDeleteButton.Text = "Delete";
            NavDeleteButton.UseVisualStyleBackColor = true;
            // 
            // NavUpdateButton
            // 
            NavUpdateButton.Location = new Point(159, 11);
            NavUpdateButton.Name = "NavUpdateButton";
            NavUpdateButton.Size = new Size(102, 39);
            NavUpdateButton.TabIndex = 1;
            NavUpdateButton.Text = "Update";
            NavUpdateButton.UseVisualStyleBackColor = true;
            // 
            // NavNewButton
            // 
            NavNewButton.BackColor = SystemColors.ControlLight;
            NavNewButton.Location = new Point(12, 11);
            NavNewButton.Name = "NavNewButton";
            NavNewButton.Size = new Size(102, 39);
            NavNewButton.TabIndex = 0;
            NavNewButton.Text = "New";
            NavNewButton.UseVisualStyleBackColor = false;
            // 
            // PersonalDetailsGroupBox
            // 
            PersonalDetailsGroupBox.BackColor = SystemColors.Control;
            PersonalDetailsGroupBox.Controls.Add(EmailAddressInput);
            PersonalDetailsGroupBox.Controls.Add(OfficePhoneInput);
            PersonalDetailsGroupBox.Controls.Add(HomePhoneInput);
            PersonalDetailsGroupBox.Controls.Add(GenderInput);
            PersonalDetailsGroupBox.Controls.Add(DOBInput);
            PersonalDetailsGroupBox.Controls.Add(LastNameInput);
            PersonalDetailsGroupBox.Controls.Add(OfficeAddressInput);
            PersonalDetailsGroupBox.Controls.Add(HomeAddressInput);
            PersonalDetailsGroupBox.Controls.Add(FirstNameInput);
            PersonalDetailsGroupBox.Controls.Add(HomePhoneLabel);
            PersonalDetailsGroupBox.Controls.Add(OfficePhoneLabel);
            PersonalDetailsGroupBox.Controls.Add(EmailAddessLabel);
            PersonalDetailsGroupBox.Controls.Add(GenderLabel);
            PersonalDetailsGroupBox.Controls.Add(DateOfBirthLabel);
            PersonalDetailsGroupBox.Controls.Add(HomeAddressLabel);
            PersonalDetailsGroupBox.Controls.Add(OfficeAddressLabel);
            PersonalDetailsGroupBox.Controls.Add(LastNameLabel);
            PersonalDetailsGroupBox.Controls.Add(FirstNameLabel);
            PersonalDetailsGroupBox.Location = new Point(259, 9);
            PersonalDetailsGroupBox.Name = "PersonalDetailsGroupBox";
            PersonalDetailsGroupBox.Size = new Size(257, 362);
            PersonalDetailsGroupBox.TabIndex = 1;
            PersonalDetailsGroupBox.TabStop = false;
            PersonalDetailsGroupBox.Text = "Personal Details";
            // 
            // EmailAddressInput
            // 
            EmailAddressInput.Location = new Point(92, 250);
            EmailAddressInput.Name = "EmailAddressInput";
            EmailAddressInput.Size = new Size(159, 23);
            EmailAddressInput.TabIndex = 17;
            // 
            // OfficePhoneInput
            // 
            OfficePhoneInput.Location = new Point(91, 287);
            OfficePhoneInput.Name = "OfficePhoneInput";
            OfficePhoneInput.Size = new Size(159, 23);
            OfficePhoneInput.TabIndex = 16;
            // 
            // HomePhoneInput
            // 
            HomePhoneInput.Location = new Point(92, 324);
            HomePhoneInput.Name = "HomePhoneInput";
            HomePhoneInput.Size = new Size(159, 23);
            HomePhoneInput.TabIndex = 15;
            // 
            // GenderInput
            // 
            GenderInput.Location = new Point(92, 213);
            GenderInput.Name = "GenderInput";
            GenderInput.Size = new Size(159, 23);
            GenderInput.TabIndex = 14;
            // 
            // DOBInput
            // 
            DOBInput.Location = new Point(92, 176);
            DOBInput.Name = "DOBInput";
            DOBInput.Size = new Size(159, 23);
            DOBInput.TabIndex = 13;
            // 
            // LastNameInput
            // 
            LastNameInput.Location = new Point(92, 65);
            LastNameInput.Name = "LastNameInput";
            LastNameInput.Size = new Size(159, 23);
            LastNameInput.TabIndex = 12;
            // 
            // OfficeAddressInput
            // 
            OfficeAddressInput.Location = new Point(92, 102);
            OfficeAddressInput.Name = "OfficeAddressInput";
            OfficeAddressInput.Size = new Size(159, 23);
            OfficeAddressInput.TabIndex = 11;
            // 
            // HomeAddressInput
            // 
            HomeAddressInput.Location = new Point(92, 139);
            HomeAddressInput.Name = "HomeAddressInput";
            HomeAddressInput.Size = new Size(159, 23);
            HomeAddressInput.TabIndex = 10;
            // 
            // FirstNameInput
            // 
            FirstNameInput.Location = new Point(92, 28);
            FirstNameInput.Name = "FirstNameInput";
            FirstNameInput.Size = new Size(159, 23);
            FirstNameInput.TabIndex = 9;
            // 
            // HomePhoneLabel
            // 
            HomePhoneLabel.AutoSize = true;
            HomePhoneLabel.Location = new Point(9, 324);
            HomePhoneLabel.Name = "HomePhoneLabel";
            HomePhoneLabel.Size = new Size(77, 15);
            HomePhoneLabel.TabIndex = 8;
            HomePhoneLabel.Text = "Home Phone";
            // 
            // OfficePhoneLabel
            // 
            OfficePhoneLabel.AutoSize = true;
            OfficePhoneLabel.Location = new Point(9, 287);
            OfficePhoneLabel.Name = "OfficePhoneLabel";
            OfficePhoneLabel.Size = new Size(76, 15);
            OfficePhoneLabel.TabIndex = 7;
            OfficePhoneLabel.Text = "Office Phone";
            // 
            // EmailAddessLabel
            // 
            EmailAddessLabel.AutoSize = true;
            EmailAddessLabel.Location = new Point(9, 250);
            EmailAddessLabel.Name = "EmailAddessLabel";
            EmailAddessLabel.Size = new Size(81, 15);
            EmailAddessLabel.TabIndex = 6;
            EmailAddessLabel.Text = "Email Address";
            // 
            // GenderLabel
            // 
            GenderLabel.AutoSize = true;
            GenderLabel.Location = new Point(9, 213);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(45, 15);
            GenderLabel.TabIndex = 5;
            GenderLabel.Text = "Gender";
            // 
            // DateOfBirthLabel
            // 
            DateOfBirthLabel.AutoSize = true;
            DateOfBirthLabel.Location = new Point(9, 176);
            DateOfBirthLabel.Name = "DateOfBirthLabel";
            DateOfBirthLabel.Size = new Size(75, 15);
            DateOfBirthLabel.TabIndex = 4;
            DateOfBirthLabel.Text = "Date Of Birth";
            // 
            // HomeAddressLabel
            // 
            HomeAddressLabel.AutoSize = true;
            HomeAddressLabel.Location = new Point(9, 139);
            HomeAddressLabel.Name = "HomeAddressLabel";
            HomeAddressLabel.Size = new Size(85, 15);
            HomeAddressLabel.TabIndex = 3;
            HomeAddressLabel.Text = "Home Address";
            // 
            // OfficeAddressLabel
            // 
            OfficeAddressLabel.AutoSize = true;
            OfficeAddressLabel.Location = new Point(9, 102);
            OfficeAddressLabel.Name = "OfficeAddressLabel";
            OfficeAddressLabel.Size = new Size(84, 15);
            OfficeAddressLabel.TabIndex = 2;
            OfficeAddressLabel.Text = "Office Address";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(9, 65);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(63, 15);
            LastNameLabel.TabIndex = 1;
            LastNameLabel.Text = "Last Name";
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(9, 28);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(64, 15);
            FirstNameLabel.TabIndex = 0;
            FirstNameLabel.Text = "First Name";
            // 
            // CustomerListPanel
            // 
            CustomerListPanel.BorderStyle = BorderStyle.FixedSingle;
            CustomerListPanel.Controls.Add(CustomerListView);
            CustomerListPanel.Controls.Add(BottomCustomerButton);
            CustomerListPanel.Controls.Add(DownCustomerButton);
            CustomerListPanel.Controls.Add(UpCustomerButton);
            CustomerListPanel.Controls.Add(TopCustomerButton);
            CustomerListPanel.Location = new Point(9, 9);
            CustomerListPanel.Name = "CustomerListPanel";
            CustomerListPanel.Size = new Size(244, 436);
            CustomerListPanel.TabIndex = 0;
            // 
            // CustomerListView
            // 
            CustomerListView.BackColor = SystemColors.Control;
            CustomerListView.Items.AddRange(new ListViewItem[] { listViewItem1 });
            CustomerListView.Location = new Point(9, 10);
            CustomerListView.Name = "CustomerListView";
            CustomerListView.Size = new Size(224, 351);
            CustomerListView.TabIndex = 0;
            CustomerListView.UseCompatibleStateImageBehavior = false;
            CustomerListView.View = View.List;
            // 
            // BottomCustomerButton
            // 
            BottomCustomerButton.Location = new Point(188, 387);
            BottomCustomerButton.Name = "BottomCustomerButton";
            BottomCustomerButton.Size = new Size(45, 35);
            BottomCustomerButton.TabIndex = 4;
            BottomCustomerButton.Text = ">>";
            BottomCustomerButton.UseVisualStyleBackColor = true;
            // 
            // DownCustomerButton
            // 
            DownCustomerButton.Location = new Point(128, 387);
            DownCustomerButton.Name = "DownCustomerButton";
            DownCustomerButton.Size = new Size(45, 35);
            DownCustomerButton.TabIndex = 3;
            DownCustomerButton.Text = ">";
            DownCustomerButton.UseVisualStyleBackColor = true;
            // 
            // UpCustomerButton
            // 
            UpCustomerButton.Location = new Point(67, 387);
            UpCustomerButton.Name = "UpCustomerButton";
            UpCustomerButton.Size = new Size(45, 35);
            UpCustomerButton.TabIndex = 2;
            UpCustomerButton.Text = "<";
            UpCustomerButton.UseVisualStyleBackColor = true;
            // 
            // TopCustomerButton
            // 
            TopCustomerButton.Location = new Point(6, 387);
            TopCustomerButton.Name = "TopCustomerButton";
            TopCustomerButton.Size = new Size(45, 35);
            TopCustomerButton.TabIndex = 1;
            TopCustomerButton.Text = "<<";
            TopCustomerButton.UseVisualStyleBackColor = true;
            // 
            // CustomersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 461);
            Controls.Add(BorderPanel);
            Name = "CustomersForm";
            Text = "Customers";
            BorderPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            AccountDetailsGroupBox.ResumeLayout(false);
            AccountDetailsGroupBox.PerformLayout();
            NavRowPanel.ResumeLayout(false);
            PersonalDetailsGroupBox.ResumeLayout(false);
            PersonalDetailsGroupBox.PerformLayout();
            CustomerListPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel BorderPanel;
        private GroupBox PersonalDetailsGroupBox;
        private Panel NavRowPanel;
        private GroupBox AccountDetailsGroupBox;
        private Panel CustomerListPanel;
        private Button BottomCustomerButton;
        private Button DownCustomerButton;
        private Button UpCustomerButton;
        private Button TopCustomerButton;
        private Button NavDeleteButton;
        private Button NavUpdateButton;
        private Button NavNewButton;
        private Panel panel1;
        private Button NavCloseButton;
        private Button NavSearchButton;
        private ListView CustomerListView;
        private Label LastNameLabel;
        private Label FirstNameLabel;
        private Label label9;
        private Label AccountNoLabel;
        private Label label10;
        private Label AccountTypeLabel;
        private Label DateOpenedLabel;
        private Label ATMCardNoLabel;
        private Label AccessCodeLabel;
        private Label ExpiryDateLabel;
        private Label BalanceLabel;
        private TextBox FirstNameInput;
        private Label HomePhoneLabel;
        private Label OfficePhoneLabel;
        private Label EmailAddessLabel;
        private Label GenderLabel;
        private Label DateOfBirthLabel;
        private Label HomeAddressLabel;
        private Label OfficeAddressLabel;
        private TextBox EmailAddressInput;
        private TextBox OfficePhoneInput;
        private TextBox HomePhoneInput;
        private TextBox GenderInput;
        private TextBox DOBInput;
        private TextBox LastNameInput;
        private TextBox OfficeAddressInput;
        private TextBox HomeAddressInput;
        private TextBox DateOpenedInput;
        private TextBox AccessCodeInput;
        private TextBox BalanceInput;
        private TextBox AccountTypeInput;
        private TextBox ATMCardNoInput;
        private TextBox ExpiryDateInput;
        private TextBox AccountNoInput;
        private PictureBox pictureBox1;
    }
}
