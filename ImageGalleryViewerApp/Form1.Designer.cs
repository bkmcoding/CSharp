namespace ImageGalleryViewer
{
    partial class ImageGalleryForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageGalleryForm));
            ImageGallery = new ImageList(components);
            ImageBox = new PictureBox();
            MenuStrip = new MenuStrip();
            fIleToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            removeToolStripMenuItem = new ToolStripMenuItem();
            leftButton = new Button();
            rightButton = new Button();
            IndexLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)ImageBox).BeginInit();
            MenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // ImageGallery
            // 
            ImageGallery.ColorDepth = ColorDepth.Depth32Bit;
            ImageGallery.ImageStream = (ImageListStreamer)resources.GetObject("ImageGallery.ImageStream");
            ImageGallery.TransparentColor = Color.Transparent;
            ImageGallery.Images.SetKeyName(0, "undraw_security_on_re_e491.png");
            // 
            // ImageBox
            // 
            ImageBox.BorderStyle = BorderStyle.FixedSingle;
            ImageBox.Location = new Point(47, 91);
            ImageBox.Name = "ImageBox";
            ImageBox.Size = new Size(350, 300);
            ImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ImageBox.TabIndex = 0;
            ImageBox.TabStop = false;
            // 
            // MenuStrip
            // 
            MenuStrip.Items.AddRange(new ToolStripItem[] { fIleToolStripMenuItem });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(434, 24);
            MenuStrip.TabIndex = 1;
            MenuStrip.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            fIleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, removeToolStripMenuItem });
            fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            fIleToolStripMenuItem.Size = new Size(37, 20);
            fIleToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(153, 22);
            openToolStripMenuItem.Text = "Add Image";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // removeToolStripMenuItem
            // 
            removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            removeToolStripMenuItem.Size = new Size(153, 22);
            removeToolStripMenuItem.Text = "Remove Image";
            removeToolStripMenuItem.Click += removeToolStripMenuItem_Click;
            // 
            // leftButton
            // 
            leftButton.Font = new Font("Tahoma", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            leftButton.Location = new Point(61, 437);
            leftButton.Name = "leftButton";
            leftButton.Size = new Size(127, 87);
            leftButton.TabIndex = 2;
            leftButton.Text = "<";
            leftButton.UseVisualStyleBackColor = true;
            leftButton.Click += leftButton_Click;
            // 
            // rightButton
            // 
            rightButton.Font = new Font("Tahoma", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rightButton.Location = new Point(249, 437);
            rightButton.Name = "rightButton";
            rightButton.Size = new Size(127, 87);
            rightButton.TabIndex = 3;
            rightButton.Text = ">";
            rightButton.UseVisualStyleBackColor = true;
            rightButton.Click += rightButton_Click;
            // 
            // IndexLabel
            // 
            IndexLabel.AutoSize = true;
            IndexLabel.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IndexLabel.Location = new Point(214, 47);
            IndexLabel.Name = "IndexLabel";
            IndexLabel.Size = new Size(20, 23);
            IndexLabel.TabIndex = 4;
            IndexLabel.Text = "0";
            // 
            // ImageGalleryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 561);
            Controls.Add(IndexLabel);
            Controls.Add(rightButton);
            Controls.Add(leftButton);
            Controls.Add(ImageBox);
            Controls.Add(MenuStrip);
            MainMenuStrip = MenuStrip;
            Name = "ImageGalleryForm";
            Text = "Image Gallery";
            ((System.ComponentModel.ISupportInitialize)ImageBox).EndInit();
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList ImageGallery;
        private PictureBox ImageBox;
        private MenuStrip MenuStrip;
        private ToolStripMenuItem fIleToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
        private Button leftButton;
        private Button rightButton;
        private Label IndexLabel;
    }
}
