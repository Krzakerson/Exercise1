namespace FirstExercise4Class
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            openFileDialog1 = new OpenFileDialog();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            picBox = new PictureBox();
            progressBar1 = new ProgressBar();
            btnSave = new Button();
            btnResize = new Button();
            btnPrev = new Button();
            btnNext = new Button();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            menu1 = new ToolStripMenuItem();
            menu2 = new ToolStripMenuItem();
            btnEdit = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(picBox);
            panel1.Controls.Add(progressBar1);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnResize);
            panel1.Controls.Add(btnPrev);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(62, 54);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(444, 286);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(689, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 52);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // picBox
            // 
            picBox.Image = (Image)resources.GetObject("picBox.Image");
            picBox.Location = new Point(749, 29);
            picBox.Name = "picBox";
            picBox.Size = new Size(51, 52);
            picBox.TabIndex = 6;
            picBox.TabStop = false;
            picBox.Click += picBox_Click_1;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(62, 390);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 23);
            progressBar1.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(548, 313);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(102, 27);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnResize
            // 
            btnResize.Location = new Point(548, 174);
            btnResize.Name = "btnResize";
            btnResize.Size = new Size(102, 27);
            btnResize.TabIndex = 3;
            btnResize.Text = "Resize";
            btnResize.UseVisualStyleBackColor = true;
            btnResize.Click += btnResize_Click;
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(548, 116);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(102, 27);
            btnPrev.TabIndex = 2;
            btnPrev.Text = "Previous image";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(548, 54);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(102, 27);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next image";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(62, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(444, 286);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menu1, menu2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // menu1
            // 
            menu1.Name = "menu1";
            menu1.Size = new Size(84, 20);
            menu1.Text = "Open Folder";
            menu1.Click += menu1_Click;
            // 
            // menu2
            // 
            menu2.Name = "menu2";
            menu2.Size = new Size(69, 20);
            menu2.Text = "Open File";
            menu2.Click += menu2_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(548, 239);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(102, 27);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Panel panel1;
        private ProgressBar progressBar1;
        private Button btnSave;
        private Button btnResize;
        private Button btnPrev;
        private Button btnNext;
        private PictureBox pictureBox1;
        private PictureBox picBox;
        private PictureBox pictureBox2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menu1;
        private ToolStripMenuItem menu2;
        private PictureBox pictureBox3;
        private Button btnEdit;
    }
}