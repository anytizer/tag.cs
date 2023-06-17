namespace browser
{
    partial class Browser
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
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button6 = new Button();
            label1 = new Label();
            label2 = new Label();
            button8 = new Button();
            button9 = new Button();
            label3 = new Label();
            toolTip1 = new ToolTip(components);
            button11 = new Button();
            textBox5 = new TextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            databaseBrowserToolStripMenuItem = new ToolStripMenuItem();
            scanADirectoryToolStripMenuItem = new ToolStripMenuItem();
            reCreateDatabaseToolStripMenuItem = new ToolStripMenuItem();
            configurationsToolStripMenuItem = new ToolStripMenuItem();
            autosaveTagsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            projectSourceCodeToolStripMenuItem = new ToolStripMenuItem();
            registeredShortcutsToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(416, 181);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Tags";
            textBox1.Size = new Size(208, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(416, 268);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Description";
            textBox2.Size = new Size(210, 65);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 339);
            button1.Name = "button1";
            button1.Size = new Size(52, 32);
            button1.TabIndex = 8;
            button1.Text = "First";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(118, 339);
            button2.Name = "button2";
            button2.Size = new Size(63, 32);
            button2.TabIndex = 9;
            button2.Text = "Prev.";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(187, 339);
            button3.Name = "button3";
            button3.Size = new Size(50, 32);
            button3.TabIndex = 10;
            button3.Text = "Next";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(286, 339);
            button4.Name = "button4";
            button4.Size = new Size(49, 32);
            button4.TabIndex = 11;
            button4.Text = "Last";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(416, 239);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "People";
            textBox3.Size = new Size(210, 23);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(416, 210);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Objects";
            textBox4.Size = new Size(210, 23);
            textBox4.TabIndex = 4;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button6
            // 
            button6.Location = new Point(519, 339);
            button6.Name = "button6";
            button6.Size = new Size(105, 32);
            button6.TabIndex = 7;
            button6.Text = "Save";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(336, 348);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 11;
            label1.Text = "CRC32 HASH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(420, 107);
            label2.Name = "label2";
            label2.Size = new Size(142, 45);
            label2.TabIndex = 0;
            label2.Text = "0 of 000";
            // 
            // button8
            // 
            button8.Location = new Point(70, 339);
            button8.Name = "button8";
            button8.Size = new Size(42, 32);
            button8.TabIndex = 12;
            button8.Text = "-";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(243, 339);
            button9.Name = "button9";
            button9.Size = new Size(37, 32);
            button9.TabIndex = 13;
            button9.Text = "+";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(416, 163);
            label3.Name = "label3";
            label3.Size = new Size(193, 15);
            label3.TabIndex = 14;
            label3.Text = "Tags | Objects | People | Description";
            // 
            // toolTip1
            // 
            toolTip1.BackColor = Color.Yellow;
            toolTip1.ForeColor = Color.Black;
            toolTip1.Popup += toolTip1_Popup;
            // 
            // button11
            // 
            button11.BackColor = SystemColors.Window;
            button11.Location = new Point(590, 33);
            button11.Name = "button11";
            button11.Size = new Size(36, 23);
            button11.TabIndex = 18;
            button11.Text = "...";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(419, 33);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Search on Tags (Full)";
            textBox5.Size = new Size(168, 23);
            textBox5.TabIndex = 17;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, configurationsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(636, 24);
            menuStrip1.TabIndex = 19;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { databaseBrowserToolStripMenuItem, scanADirectoryToolStripMenuItem, reCreateDatabaseToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // databaseBrowserToolStripMenuItem
            // 
            databaseBrowserToolStripMenuItem.Name = "databaseBrowserToolStripMenuItem";
            databaseBrowserToolStripMenuItem.Size = new Size(177, 22);
            databaseBrowserToolStripMenuItem.Text = "Database Browser";
            databaseBrowserToolStripMenuItem.Click += databaseBrowserToolStripMenuItem_Click;
            // 
            // scanADirectoryToolStripMenuItem
            // 
            scanADirectoryToolStripMenuItem.Name = "scanADirectoryToolStripMenuItem";
            scanADirectoryToolStripMenuItem.Size = new Size(177, 22);
            scanADirectoryToolStripMenuItem.Text = "Scan a Directory";
            scanADirectoryToolStripMenuItem.Click += scanADirectoryToolStripMenuItem_Click;
            // 
            // reCreateDatabaseToolStripMenuItem
            // 
            reCreateDatabaseToolStripMenuItem.Name = "reCreateDatabaseToolStripMenuItem";
            reCreateDatabaseToolStripMenuItem.Size = new Size(177, 22);
            reCreateDatabaseToolStripMenuItem.Text = "Re-Create Database";
            reCreateDatabaseToolStripMenuItem.Click += reCreateDatabaseToolStripMenuItem_Click;
            // 
            // configurationsToolStripMenuItem
            // 
            configurationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { autosaveTagsToolStripMenuItem });
            configurationsToolStripMenuItem.Name = "configurationsToolStripMenuItem";
            configurationsToolStripMenuItem.Size = new Size(98, 20);
            configurationsToolStripMenuItem.Text = "Configurations";
            // 
            // autosaveTagsToolStripMenuItem
            // 
            autosaveTagsToolStripMenuItem.Name = "autosaveTagsToolStripMenuItem";
            autosaveTagsToolStripMenuItem.Size = new Size(154, 22);
            autosaveTagsToolStripMenuItem.Text = "Auto-save Tags";
            autosaveTagsToolStripMenuItem.Click += autosaveTagsToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { projectSourceCodeToolStripMenuItem, registeredShortcutsToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // projectSourceCodeToolStripMenuItem
            // 
            projectSourceCodeToolStripMenuItem.Name = "projectSourceCodeToolStripMenuItem";
            projectSourceCodeToolStripMenuItem.Size = new Size(182, 22);
            projectSourceCodeToolStripMenuItem.Text = "Project Source Code";
            projectSourceCodeToolStripMenuItem.Click += projectSourceCodeToolStripMenuItem_Click;
            // 
            // registeredShortcutsToolStripMenuItem
            // 
            registeredShortcutsToolStripMenuItem.Name = "registeredShortcutsToolStripMenuItem";
            registeredShortcutsToolStripMenuItem.Size = new Size(182, 22);
            registeredShortcutsToolStripMenuItem.Text = "Registered Shortcuts";
            registeredShortcutsToolStripMenuItem.Click += registeredShortcutsToolStripMenuItem_Click;
            // 
            // Browser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 384);
            Controls.Add(textBox5);
            Controls.Add(button11);
            Controls.Add(label3);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Browser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Image Tagger";
            Load += Browser_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button6;
        private Label label1;
        private Label label2;
        private Button button8;
        private Button button9;
        private Label label3;
        private ToolTip toolTip1;
        private Button button11;
        private TextBox textBox5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem scanADirectoryToolStripMenuItem;
        private ToolStripMenuItem databaseBrowserToolStripMenuItem;
        private ToolStripMenuItem configurationsToolStripMenuItem;
        private ToolStripMenuItem autosaveTagsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem projectSourceCodeToolStripMenuItem;
        private ToolStripMenuItem registeredShortcutsToolStripMenuItem;
        private ToolStripMenuItem reCreateDatabaseToolStripMenuItem;
    }
}