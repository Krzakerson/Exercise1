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
        string folderpath = "";
        string[] files;
        int n;
        int manyoffile;
        private void picBox_Click_1(object sender, EventArgs e)
        {

            panel1.BackColor = Color.WhiteSmoke;


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.DimGray;

        }

        private void menu2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
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

        private void menu1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
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
    }
}