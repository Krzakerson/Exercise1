using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace FirstExercise4Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnSave.Enabled = true;

        }

        string selectedimage = "";
        string folderpath = "";
        string[] files;
        int n;
        int manyoffile;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.WhiteSmoke;
        }
        private void picBox_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.DimGray;
        }






        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                n++;
                selectedimage = files[n];
                string fileext = Path.GetExtension(files[n]);
                if (fileext == ".jpg" || fileext == ".png" || fileext == ".jpeg")
                {
                    pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox3.Image = new Bitmap(files[n]);
                }
                else
                {
                    MessageBox.Show("Format pliku nie jest obsługiwany");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            try
            {
                n--;
                selectedimage = files[n];   
                string fileext = Path.GetExtension(files[n]);
                if (fileext == ".jpg" || fileext == ".png" || fileext == ".jpeg")
                {
                    pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox3.Image = new Bitmap(files[n]);
                }
                else
                {
                    MessageBox.Show("Format pliku nie jest obsługiwany");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        }

    
        private void menu1_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                btnNext.Enabled = true;
                btnPrev.Enabled = true;
                btnResize.Enabled = true;
                btnEdit.Enabled = true;
                btnSave.Enabled = true;
                folderpath = folderBrowserDialog.SelectedPath;
                files = Directory.GetFiles(folderpath);


                manyoffile = files.Length;

                n = 0;

                string fileext = Path.GetExtension(files[n]);

                if (fileext == ".jpg" || fileext == ".png" || fileext == ".jpeg" || fileext == ".bmp")
                {
                    pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
                    selectedimage = files[n];   
                    pictureBox3.Image = new Bitmap(files[n]);
                }
                else
                {
                    MessageBox.Show("Format pliku nie jest obsługiwany");
                }
            }
        }

        private void menu2_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                btnResize.Enabled = true;
                btnEdit.Enabled = true;
                btnSave.Enabled = true;
                string ext = Path.GetExtension(openFileDialog1.FileName);

                if (ext == ".jpg" || ext == ".png" || ext == ".jpeg" || ext == ".bmp")
                {
                    pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
                    selectedimage = openFileDialog1.FileName;
                    pictureBox3.Image = new Bitmap(openFileDialog1.FileName);
                }
                else
                {
                    MessageBox.Show("Format pliku nie jest obsługiwany");
                }
            }
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(selectedimage);
            form2.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (pictureBox3 != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {





                    pictureBox3.Image.Save(saveFileDialog.FileName);
                }
            }
            else
            {
                MessageBox.Show("There is not image to be save");
            }






        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog(); 
        }
    }
}