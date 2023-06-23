using libraries;
using libraries.dtos;
using libraries.models;

namespace browser
{
    public partial class Browser4 : Form
    {
        private bool autosave = false;
        private int currentIndex = 0;
        private string[] images = new string[] { };
        public Browser4()
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
                                                                   // this.images = this.scan_image_db(); // db scan

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
            Scanner scanner = new Scanner();
            return scanner.scan_image_db();
        }

        private void DisplayImage()
        {
            string fileToDisplay = this.currenttlyIndexedPath();
            if (fileToDisplay != "")
            {
                pictureBox1.ImageLocation = fileToDisplay;

                TagInformationDTO tag = this.PullTagInformation(fileToDisplay);
                this.textBox1.Text = tag.tags;
                this.textBox4.Text = tag.objects;
                this.textBox3.Text = tag.people;
                this.textBox2.Text = tag.description;
                this.textBox6.Text = tag.notes;
                this.textBox7.Text = tag.colors;
                this.label1.Text = tag.crc32;

                this.label2.Text = (this.currentIndex + 1) + " of " + this.images.Length;

                // update form title
                this.Text = new FileInfo(fileToDisplay).Name;

                //this.listBox1.SetSelected(this.currentIndex, true);
                //this.listBox1.TopIndex = this.currentIndex;
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
                tag.tags = image.ImageTags;
                tag.objects = image.ImageObjects;
                tag.people = image.ImagePeople;
                tag.description = image.ImageDescription;
                tag.notes = image.ImageNotes;
                tag.colors = image.ImageColors;
            }

            return tag;
        }

        private string[] scan_images_live(string selectedPath)
        {
            Scanner scanner = new Scanner();
            string[] images = scanner.list(selectedPath);
            return images;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (this.autosave) this.SaveTagInformation();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (this.autosave) this.SaveTagInformation();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (this.autosave) this.SaveTagInformation();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.autosave) this.SaveTagInformation();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.navigateToFirst();
        }

        private void navigateToFirst()
        {
            this.currentIndex = 0;
            DisplayImage();
        }

        private void navigateToLast()
        {
            this.currentIndex = this.images.Count() - 1;
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
            this.navigateToLast();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.SaveTagInformation();
        }

        private void SaveTagInformation()
        {
            // saving...
            TagInformationDTO tag = this.collect();
            if (tag.path != "")
            {
                Scanner scanner = new Scanner();
                scanner.update(tag);
            }
        }

        private TagInformationDTO collect()
        {
            TagInformationDTO tag = new TagInformationDTO();
            tag.path = this.currenttlyIndexedPath(); ;
            tag.tags = this.textBox1.Text.ToString();
            tag.objects = this.textBox4.Text.ToString();
            tag.people = this.textBox3.Text.ToString();
            tag.description = this.textBox2.Text.ToString();
            tag.notes = this.textBox6.Text.ToString();
            tag.colors = this.textBox7.Text.ToString();

            return tag;
        }

        private void BrowseDatabase()
        {
            this.images = this.scan_image_db();
            this.update_listbox();
        }

        private void update_listbox()
        {
            if (this.images.Length >= 1)
            {
                this.currentIndex = 0;

                DisplayImage();
                this.listBox1.DataSource = this.images;
            }
            else
            {
                MessageBox.Show("Images not found.", "No data!");
            }
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
            //else if (keyData == (Keys.Control | Keys.O))
            //{
            //    handled = true;
            //
            //    this.OpenScanDirectory();
            //}
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
            else if (keyData == (Keys.Control | Keys.Home))
            {
                handled = true;
                this.navigateToFirst();
            }
            else if (keyData == (Keys.Control | Keys.End))
            {
                handled = true;
                this.navigateToLast();
            }
            else if (keyData == Keys.Enter)
            {
                handled = true;
                this.search();
            }

            return handled ? handled : base.ProcessCmdKey(ref msg, keyData);
        }

        private void search()
        {
            string search = this.textBox5.Text.ToString().ToLower();

            Scanner scanner = new Scanner();
            this.images = scanner.search(search);

            this.update_listbox();
        }

        // override the hops with index
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
            toolTip1.AutomaticDelay = 700;
            toolTip1.SetToolTip(this.button1, "Ctrl + Home");
            toolTip1.SetToolTip(this.button4, "Ctrl + End");
            toolTip1.SetToolTip(this.button2, "Ctrl + Left Arrow");
            toolTip1.SetToolTip(this.button3, "Ctrl + Right Arrow");
            toolTip1.SetToolTip(this.button9, "Ctrl + PageDown");
            toolTip1.SetToolTip(this.button8, "Ctrl + PageUp");
            toolTip1.SetToolTip(this.button11, "Search on Tags: ENTER");

            this.BrowseDatabase();
        }

        private void help()
        {
            string help = "";
            help += "Ctrl + Left Arrow";
            help += "\r\n" + "Ctrl + Right Arrow";
            help += "\r\n" + "Ctrl + PageUp";
            help += "\r\n" + "Ctrl + PageDown";
            help += "\r\n" + "Ctrl + Home";
            help += "\r\n" + "Ctrl + End";
            help += "\r\n" + "Ctrl + S";
            help += "\r\n" + "Ctrl + O";
            help += "\r\n" + "ENTER";
            help += "\r\n" + "F1";
            help += "\r\n" + "Alt + F4";

            MessageBox.Show(help, "Keyboard Shortcuts", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.search();
        }

        private void scanADirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenScanDirectory();
        }

        private void databaseBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BrowseDatabase();
        }

        private void projectSourceCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("@anytizer/tag.cs", "At GitHub");
        }

        private void registeredShortcutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.help();
        }

        private void autosaveTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.autosaveTagsToolStripMenuItem.Checked = !this.autosaveTagsToolStripMenuItem.Checked;
            this.autosave = this.autosaveTagsToolStripMenuItem.Checked;

            if (!this.autosave) MessageBox.Show("Press Ctrl + S to save the tag manually.", "Remember!");
        }

        private void reCreateDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Confirm?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Scanner scanner = new Scanner();
                string batch = scanner.empty();

                MessageBox.Show("Database backed up and emptied.", batch);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox? lb = sender as ListBox;
            if (lb != null)
            {
                //MessageBox.Show(lb.SelectedValue.ToString());
                this.JumpTo(lb.SelectedIndex);
                //this.pictureBox1.ImageLocation = lb.SelectedValue.ToString();
            }

        }

        private void Browser3_Resize(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void export()
        {
            MessageBox.Show(string.Join("\n", this.images.Take(30)), "CSV, max 30 rows!");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.export();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.copy_files();
        }

        private void copy_files()
        {
            MessageBox.Show("Search, Export the CSV and copy the Files.", "Not implemented");
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}