namespace CS_REG_98_7654_3210
{
    partial class ConversionFrm
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
            ConvertFromGrp = new GroupBox();
            FromTerabitRb = new RadioButton();
            FromGigabitRb = new RadioButton();
            FromMegabitRb = new RadioButton();
            FromKilobitRb = new RadioButton();
            FromByteRb = new RadioButton();
            UserInputTxt = new TextBox();
            UserInputLbl = new Label();
            ConvertToGrp = new GroupBox();
            ResultTxt = new TextBox();
            ConvertBtn = new Button();
            ToTerabitRb = new RadioButton();
            label1 = new Label();
            ToGigabitRb = new RadioButton();
            ToKilobitRb = new RadioButton();
            ToMegabitRb = new RadioButton();
            ToByteRb = new RadioButton();
            ExitBtn = new Button();
            ConvertFromGrp.SuspendLayout();
            ConvertToGrp.SuspendLayout();
            SuspendLayout();
            // 
            // ConvertFromGrp
            // 
            ConvertFromGrp.Controls.Add(FromTerabitRb);
            ConvertFromGrp.Controls.Add(FromGigabitRb);
            ConvertFromGrp.Controls.Add(FromMegabitRb);
            ConvertFromGrp.Controls.Add(FromKilobitRb);
            ConvertFromGrp.Controls.Add(FromByteRb);
            ConvertFromGrp.Controls.Add(UserInputTxt);
            ConvertFromGrp.Controls.Add(UserInputLbl);
            ConvertFromGrp.Location = new Point(24, 12);
            ConvertFromGrp.Name = "ConvertFromGrp";
            ConvertFromGrp.Size = new Size(400, 300);
            ConvertFromGrp.TabIndex = 0;
            ConvertFromGrp.TabStop = false;
            ConvertFromGrp.Text = "Convert From";
            // 
            // FromTerabitRb
            // 
            FromTerabitRb.AutoSize = true;
            FromTerabitRb.Location = new Point(18, 264);
            FromTerabitRb.Name = "FromTerabitRb";
            FromTerabitRb.Size = new Size(84, 19);
            FromTerabitRb.TabIndex = 6;
            FromTerabitRb.TabStop = true;
            FromTerabitRb.Text = "Terabit (Tb)";
            FromTerabitRb.UseVisualStyleBackColor = true;
            // 
            // FromGigabitRb
            // 
            FromGigabitRb.AutoSize = true;
            FromGigabitRb.Location = new Point(18, 214);
            FromGigabitRb.Name = "FromGigabitRb";
            FromGigabitRb.Size = new Size(89, 19);
            FromGigabitRb.TabIndex = 5;
            FromGigabitRb.TabStop = true;
            FromGigabitRb.Text = "Gigabit (Gb)";
            FromGigabitRb.UseVisualStyleBackColor = true;
            // 
            // FromMegabitRb
            // 
            FromMegabitRb.AutoSize = true;
            FromMegabitRb.Location = new Point(18, 164);
            FromMegabitRb.Name = "FromMegabitRb";
            FromMegabitRb.Size = new Size(98, 19);
            FromMegabitRb.TabIndex = 4;
            FromMegabitRb.TabStop = true;
            FromMegabitRb.Text = "Megabit (Mb)";
            FromMegabitRb.UseVisualStyleBackColor = true;
            // 
            // FromKilobitRb
            // 
            FromKilobitRb.AutoSize = true;
            FromKilobitRb.Location = new Point(18, 114);
            FromKilobitRb.Name = "FromKilobitRb";
            FromKilobitRb.Size = new Size(84, 19);
            FromKilobitRb.TabIndex = 3;
            FromKilobitRb.TabStop = true;
            FromKilobitRb.Text = "Kilobit (Kb)";
            FromKilobitRb.UseVisualStyleBackColor = true;
            // 
            // FromByteRb
            // 
            FromByteRb.AutoSize = true;
            FromByteRb.Location = new Point(18, 64);
            FromByteRb.Name = "FromByteRb";
            FromByteRb.Size = new Size(66, 19);
            FromByteRb.TabIndex = 2;
            FromByteRb.TabStop = true;
            FromByteRb.Text = "Byte (B)";
            FromByteRb.UseVisualStyleBackColor = true;
            // 
            // UserInputTxt
            // 
            UserInputTxt.Location = new Point(253, 28);
            UserInputTxt.Name = "UserInputTxt";
            UserInputTxt.Size = new Size(100, 23);
            UserInputTxt.TabIndex = 1;
            // 
            // UserInputLbl
            // 
            UserInputLbl.AutoSize = true;
            UserInputLbl.Location = new Point(6, 31);
            UserInputLbl.Name = "UserInputLbl";
            UserInputLbl.Size = new Size(231, 30);
            UserInputLbl.TabIndex = 0;
            UserInputLbl.Text = "Enter the value to convert from then select\r\nthe data size: \r\n";
            // 
            // ConvertToGrp
            // 
            ConvertToGrp.Controls.Add(ResultTxt);
            ConvertToGrp.Controls.Add(ConvertBtn);
            ConvertToGrp.Controls.Add(ToTerabitRb);
            ConvertToGrp.Controls.Add(label1);
            ConvertToGrp.Controls.Add(ToGigabitRb);
            ConvertToGrp.Controls.Add(ToKilobitRb);
            ConvertToGrp.Controls.Add(ToMegabitRb);
            ConvertToGrp.Controls.Add(ToByteRb);
            ConvertToGrp.Location = new Point(512, 12);
            ConvertToGrp.Name = "ConvertToGrp";
            ConvertToGrp.Size = new Size(400, 300);
            ConvertToGrp.TabIndex = 1;
            ConvertToGrp.TabStop = false;
            ConvertToGrp.Text = "Convert To";
            // 
            // ResultTxt
            // 
            ResultTxt.Location = new Point(196, 145);
            ResultTxt.Name = "ResultTxt";
            ResultTxt.Size = new Size(198, 23);
            ResultTxt.TabIndex = 7;
            // 
            // ConvertBtn
            // 
            ConvertBtn.Location = new Point(196, 95);
            ConvertBtn.Name = "ConvertBtn";
            ConvertBtn.Size = new Size(75, 23);
            ConvertBtn.TabIndex = 12;
            ConvertBtn.Text = "Convert";
            ConvertBtn.UseVisualStyleBackColor = true;
            ConvertBtn.Click += ConvertBtn_Click;
            // 
            // ToTerabitRb
            // 
            ToTerabitRb.AutoSize = true;
            ToTerabitRb.Location = new Point(39, 264);
            ToTerabitRb.Name = "ToTerabitRb";
            ToTerabitRb.Size = new Size(84, 19);
            ToTerabitRb.TabIndex = 11;
            ToTerabitRb.TabStop = true;
            ToTerabitRb.Text = "Terabit (Tb)";
            ToTerabitRb.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(180, 15);
            label1.TabIndex = 7;
            label1.Text = "Select the data size to convert to:";
            // 
            // ToGigabitRb
            // 
            ToGigabitRb.AutoSize = true;
            ToGigabitRb.Location = new Point(39, 214);
            ToGigabitRb.Name = "ToGigabitRb";
            ToGigabitRb.Size = new Size(89, 19);
            ToGigabitRb.TabIndex = 10;
            ToGigabitRb.TabStop = true;
            ToGigabitRb.Text = "Gigabit (Gb)";
            ToGigabitRb.UseVisualStyleBackColor = true;
            // 
            // ToKilobitRb
            // 
            ToKilobitRb.AutoSize = true;
            ToKilobitRb.Location = new Point(39, 114);
            ToKilobitRb.Name = "ToKilobitRb";
            ToKilobitRb.Size = new Size(84, 19);
            ToKilobitRb.TabIndex = 8;
            ToKilobitRb.TabStop = true;
            ToKilobitRb.Text = "Kilobit (Kb)";
            ToKilobitRb.UseVisualStyleBackColor = true;
            // 
            // ToMegabitRb
            // 
            ToMegabitRb.AutoSize = true;
            ToMegabitRb.Location = new Point(39, 164);
            ToMegabitRb.Name = "ToMegabitRb";
            ToMegabitRb.Size = new Size(98, 19);
            ToMegabitRb.TabIndex = 9;
            ToMegabitRb.TabStop = true;
            ToMegabitRb.Text = "Megabit (Mb)";
            ToMegabitRb.UseVisualStyleBackColor = true;
            // 
            // ToByteRb
            // 
            ToByteRb.AutoSize = true;
            ToByteRb.Location = new Point(39, 64);
            ToByteRb.Name = "ToByteRb";
            ToByteRb.Size = new Size(66, 19);
            ToByteRb.TabIndex = 7;
            ToByteRb.TabStop = true;
            ToByteRb.Text = "Byte (B)";
            ToByteRb.UseVisualStyleBackColor = true;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(432, 378);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(75, 23);
            ExitBtn.TabIndex = 2;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // ConversionFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 450);
            Controls.Add(ExitBtn);
            Controls.Add(ConvertToGrp);
            Controls.Add(ConvertFromGrp);
            Name = "ConversionFrm";
            Text = "Data Storage Conversion";
            ConvertFromGrp.ResumeLayout(false);
            ConvertFromGrp.PerformLayout();
            ConvertToGrp.ResumeLayout(false);
            ConvertToGrp.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ConvertFromGrp;
        private GroupBox ConvertToGrp;
        private RadioButton FromByteRb;
        private TextBox UserInputTxt;
        private Label UserInputLbl;
        private RadioButton FromTerabitRb;
        private RadioButton FromGigabitRb;
        private RadioButton FromMegabitRb;
        private RadioButton FromKilobitRb;
        private Label label1;
        private Button ConvertBtn;
        private RadioButton ToTerabitRb;
        private RadioButton ToGigabitRb;
        private RadioButton ToKilobitRb;
        private RadioButton ToMegabitRb;
        private RadioButton ToByteRb;
        private TextBox ResultTxt;
        private Button ExitBtn;
    }
}
