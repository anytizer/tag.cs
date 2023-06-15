using libraries;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace browser
{
    public partial class Browser : Form
    {
        private int currentIndex = 0;
        private string[] images = new string[] { };
        public Browser()
        {
            InitializeComponent();

            this.KeyPreview = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.OpenScanDirectory();
        }

        private void OpenScanDirectory()
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            DialogResult result = folderDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string selectedPath = folderDialog.SelectedPath;
                this.images = this.scan_images_live(selectedPath); // live scan
                                                                   //this.images = this.scan_image_db(); // db scan

                // instantly build the database
                Cursor.Current = Cursors.WaitCursor;

                Scanner scanner = new Scanner();
                scanner.build(selectedPath);

                Cursor.Current = Cursors.Default;



                this.currentIndex = 0;
                DisplayImage();
            }
        }

        private string[] scan_image_db()
        {
            TaggerContext dbc = new TaggerContext();
            string[] images = dbc.images.Select(x => x.ImagePath).ToArray();
            return images;
        }

        private void DisplayImage()
        {
            string fileToDisplay = this.currenttlyIndexedPath();
            if (fileToDisplay != "")
            {
                pictureBox1.ImageLocation = fileToDisplay;

                TagInformationDTO tag = PullTagInformation(fileToDisplay);
                this.textBox1.Text = tag.tags;
                this.textBox4.Text = tag.objects;
                this.textBox3.Text = tag.people;
                this.textBox2.Text = tag.description;
                this.label1.Text = tag.crc32;

                this.label2.Text = (this.currentIndex + 1) + " of " + this.images.Length;

                // update form title
                this.Text = new FileInfo(fileToDisplay).Name;
            }
        }

        private string currenttlyIndexedPath()
        {
            string path = "";
            if (this.images.Length != 0)
            {
                if (currentIndex >= images.Length)
                {
                    this.currentIndex = this.images.Length - 1; // last
                }

                if (currentIndex < 0)
                {
                    this.currentIndex = 0; // first
                }

                path = this.images[this.currentIndex];
            }

            return path;
        }

        private TagInformationDTO PullTagInformation(string fileToDisplay)
        {
            TagInformationDTO tag = new TagInformationDTO();

            TaggerContext dbc = new TaggerContext();
            ImageModel? image = dbc.images.Where(x => x.ImagePath == fileToDisplay).FirstOrDefault();
            if (image != null)
            {
                tag.path = image.ImagePath;
                tag.crc32 = image.ImageCRC32;
                tag.batch = image.ImageBatch;
                tag.filesize = image.ImageFileSize;
                tag.height = image.ImageHeight;
                tag.width = image.ImageWidth;
                tag.orientation = image.ImageOrientation;
                tag.objects = image.ImageObjects;
                tag.people = image.ImagePeople;
                tag.description = image.ImageDescription;
                tag.tags = image.ImageTags;
            }

            return tag;
        }

        private string[] scan_images_live(string selectedPath)
        {
            Scanner scanner = new Scanner();
            string[] images = scanner.GetImageFiles(selectedPath);
            return images;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.currentIndex = 0;
            DisplayImage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.JumpTo(-1);

            //this.currentIndex -= 1;
            ////if(currentIndex<0) currentIndex = 0; // stop
            //if (currentIndex < 0) currentIndex = this.images.Count() - 1; // stop
            //DisplayImage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.JumpTo(+1);

            //this.currentIndex += 1;
            //if (currentIndex > this.images.Count() - 1) currentIndex = 0; // loop through
            //DisplayImage();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.currentIndex = this.images.Count() - 1;
            DisplayImage();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.SaveTagInformation();
        }

        private void SaveTagInformation()
        {
            // saving...
            string fileToDisplay = this.currenttlyIndexedPath();
            if (fileToDisplay != "")
            {
                TaggerContext dbc = new TaggerContext();
                ImageModel? image = dbc.images.Where(x => x.ImagePath == fileToDisplay).FirstOrDefault();
                if (image != null)
                {
                    image.ImageTags = this.textBox1.Text.ToString();
                    image.ImageObjects = this.textBox4.Text.ToString();
                    image.ImagePeople = this.textBox3.Text.ToString();
                    image.ImageDescription = this.textBox2.Text.ToString();

                    dbc.SaveChanges();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.images = this.scan_image_db();

            this.currentIndex = 0;
            DisplayImage();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.JumpTo(-10);
            //this.currentIndex -= 10;
            //DisplayImage();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.JumpTo(+10);
            //this.currentIndex += 10;
            //DisplayImage();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool handled = false;
            if (keyData == (Keys.Control | Keys.S))
            {
                handled = true;

                this.SaveTagInformation();
            }
            else if (keyData == (Keys.Control | Keys.O))
            {
                handled = true;

                this.OpenScanDirectory();
            }
            else if (keyData == (Keys.Control | Keys.Left))
            {
                handled = true;

                this.currentIndex -= 1;
                DisplayImage();
            }
            else if (keyData == (Keys.Control | Keys.Right))
            {
                handled = true;

                this.currentIndex += 1;
                DisplayImage();

            }
            else if (keyData == (Keys.Control | Keys.PageUp))
            {
                handled = true;

                this.JumpTo(+10);
            }
            else if (keyData == (Keys.Control | Keys.PageDown))
            {
                handled = true;

                this.JumpTo(-10);
            }

            return (handled) ? handled : base.ProcessCmdKey(ref msg, keyData);
        }

        private void JumpTo(int hops)
        {
            this.currentIndex += hops;
            DisplayImage();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //ColorsForm cf = new ColorsForm();
            //cf.ShowDialog();
        }

        private void Browser_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.button5, "Scan a directory and build database!");
            toolTip1.SetToolTip(this.button7, "Load from image database.");
            toolTip1.SetToolTip(this.button2, "Ctrl + Left Arrow");
            toolTip1.SetToolTip(this.button3, "Ctrl + Right Arrow");
            toolTip1.SetToolTip(this.button9, "Ctrl + PageDown");
            toolTip1.SetToolTip(this.button8, "Ctrl + PageUp");
            toolTip1.AutomaticDelay = 1000;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string help = "";
            help += "\r\n" + "Keyboard shortcuts:";
            help += "\r\n" + "Ctrl + Left Arrow";
            help += "\r\n" + "Ctrl + Right Arrow";
            help += "\r\n" + "Ctrl + PageUp";
            help += "\r\n" + "Ctrl + PageDown";
            help += "\r\n" + "Ctrl + S";
            help += "\r\n" + "Ctrl + O";

            MessageBox.Show(help, "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}