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


        }
        bool IsDrawing = false;
        Bitmap bitmap;
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
                string fileext = Path.GetExtension(files[n]);
                if (fileext == ".jpg" || fileext == ".png" || fileext == ".jpeg")
                {
                    pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox3.Image = new Bitmap(files[n]);
                }
                else
                {
                    MessageBox.Show("Format pliku nie jest obs³ugiwany");
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
                string fileext = Path.GetExtension(files[n]);
                if (fileext == ".jpg" || fileext == ".png" || fileext == ".jpeg")
                {
                    pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox3.Image = new Bitmap(files[n]);
                }
                else
                {
                    MessageBox.Show("Format pliku nie jest obs³ugiwany");
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if(pictureBox3.Image != null)
            {
                var pen = new Pen(Color.Red, 1);
                var bmp = (Bitmap)pictureBox3.Image;
            }
            else
            {
                MessageBox.Show("First load image");
            }
         
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Image != null)
            {
                var pen = new Pen(Color.Green, 1);
                var bmp = (Bitmap)pictureBox3.Image;
            }
            else
            {
                MessageBox.Show("First load image");
            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Image != null)
            {
                var pen = new Pen(Color.White, 1);
                var bmp = (Bitmap)pictureBox3.Image;
            }
            else
            {
                MessageBox.Show("First load image");
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Image != null)
            {
                var pen = new Pen(Color.Black, 1);
                var bmp = (Bitmap)pictureBox3.Image;
            }
            else
            {
                MessageBox.Show("First load image");
            }
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

                if (fileext == ".jpg" || fileext == ".png" || fileext == ".jpeg")
                {
                    pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox3.Image = new Bitmap(files[n]);
                }
                else
                {
                    MessageBox.Show("Format pliku nie jest obs³ugiwany");
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

                if (ext == ".jpg" || ext == ".png" || ext == ".jpeg")
                {
                    pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox3.Image = new Bitmap(openFileDialog1.FileName);
                }
                else
                {
                    MessageBox.Show("Format pliku nie jest obs³ugiwany");
                }
            }
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {

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


    }
}