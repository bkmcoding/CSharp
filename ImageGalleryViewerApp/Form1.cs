namespace ImageGalleryViewer
{
    public partial class ImageGalleryForm : Form
    {
        public int GalleryIndex = 1;
        public ImageGalleryForm()
        {
            InitializeComponent();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog imageFile = new OpenFileDialog
            {
                Title = "Add Image File",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "png",
                Filter = @"png files (*.png)|*.png",
                FilterIndex = 2,
                RestoreDirectory = true,
            };
            imageFile.ShowDialog();
            Console.WriteLine(imageFile.FileName);
            if (!imageFile.CheckFileExists) return;
            ImageGallery.Images.Add(imageFile.FileName, Image.FromFile(imageFile.FileName));
            LoadImage();
        }
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageGallery.Images.RemoveAt(GalleryIndex);
            LoadImage();
        }
        private void leftButton_Click(object sender, EventArgs e)
        {
            if (GalleryIndex - 1 == 0)
            {
                MessageBox.Show("Cannot navigate lower than index 0", "User Error");
            }
            else
            {
                GalleryIndex--;
                LoadImage();
            }
            
        }
        private void rightButton_Click(object sender, EventArgs e)
        {
            if (GalleryIndex - 1 < ImageGallery.Images.Count)
            {
                GalleryIndex++;
                LoadImage();
            }
            
        }

        private void LoadImage()
        {
            ImageBox.Image = ImageGallery.Images[GalleryIndex - 1];
            IndexLabel.Text = Convert.ToString(GalleryIndex);
        }

        
    }
}
