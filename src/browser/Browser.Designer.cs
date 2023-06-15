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
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            button7 = new Button();
            label2 = new Label();
            button8 = new Button();
            button9 = new Button();
            label3 = new Label();
            button10 = new Button();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(416, 160);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Tags";
            textBox1.Size = new Size(210, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(416, 247);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Description";
            textBox2.Size = new Size(210, 65);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 318);
            button1.Name = "button1";
            button1.Size = new Size(52, 32);
            button1.TabIndex = 8;
            button1.Text = "First";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(118, 318);
            button2.Name = "button2";
            button2.Size = new Size(63, 32);
            button2.TabIndex = 9;
            button2.Text = "Prev.";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(187, 318);
            button3.Name = "button3";
            button3.Size = new Size(50, 32);
            button3.TabIndex = 10;
            button3.Text = "Next";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(286, 318);
            button4.Name = "button4";
            button4.Size = new Size(49, 32);
            button4.TabIndex = 11;
            button4.Text = "Last";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(416, 218);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "People";
            textBox3.Size = new Size(210, 23);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(416, 189);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Objects";
            textBox4.Size = new Size(210, 23);
            textBox4.TabIndex = 4;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 128, 0);
            button5.Location = new Point(590, 12);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(36, 27);
            button5.TabIndex = 1;
            button5.Text = "...";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(519, 318);
            button6.Name = "button6";
            button6.Size = new Size(105, 32);
            button6.TabIndex = 7;
            button6.Text = "Save (Ctrl+S)";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Green;
            label1.Location = new Point(336, 327);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 11;
            label1.Text = "CRC32 HASH";
            // 
            // button7
            // 
            button7.Location = new Point(416, 12);
            button7.Name = "button7";
            button7.Size = new Size(171, 27);
            button7.TabIndex = 2;
            button7.Text = "Open DB Batch";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(420, 86);
            label2.Name = "label2";
            label2.Size = new Size(124, 45);
            label2.TabIndex = 0;
            label2.Text = "0 / 000";
            // 
            // button8
            // 
            button8.Location = new Point(70, 318);
            button8.Name = "button8";
            button8.Size = new Size(42, 32);
            button8.TabIndex = 12;
            button8.Text = "-";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(243, 318);
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
            label3.Location = new Point(416, 142);
            label3.Name = "label3";
            label3.Size = new Size(193, 15);
            label3.TabIndex = 14;
            label3.Text = "Tags | Objects | People | Description";
            // 
            // button10
            // 
            button10.Location = new Point(420, 318);
            button10.Name = "button10";
            button10.Size = new Size(93, 32);
            button10.TabIndex = 15;
            button10.Text = "Help";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // toolTip1
            // 
            toolTip1.BackColor = Color.Yellow;
            toolTip1.ForeColor = Color.Black;
            toolTip1.Popup += toolTip1_Popup;
            // 
            // Browser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 358);
            Controls.Add(button10);
            Controls.Add(label3);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(label2);
            Controls.Add(button7);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Browser";
            Text = "Image Tagger";
            Load += Browser_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button button5;
        private Button button6;
        private Label label1;
        private Button button7;
        private Label label2;
        private Button button8;
        private Button button9;
        private Label label3;
        private Button button10;
        private ToolTip toolTip1;
    }
}