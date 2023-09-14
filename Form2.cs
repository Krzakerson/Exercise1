using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstExercise4Class
{
    public partial class Form2 : Form
    {

        string imagepath;
        bool moving = false;
        Bitmap bitmap;
        Pen pen = new Pen(Color.Black, 5);
        public Form2(string value)
        {

            InitializeComponent();


            imagepath = value;
            pictureBox1.Image = new Bitmap(imagepath);
            bitmap = new Bitmap(pictureBox1.Image);




            //bitmap = new Bitmap(pictureBox1.Width,pictureBox1.Height);


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pen.Width = 9.0F;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pen.Color = pictureBox2.BackColor;

        }

       

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pen.Color = pictureBox3.BackColor;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pen.Color = pictureBox4.BackColor;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pen.Color = pictureBox5.BackColor;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pen.Color = pictureBox6.BackColor;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pen.Color = pictureBox7.BackColor;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pen.Color = pictureBox8.BackColor;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (moving == true)
            {
                moving = false;
            }
            else
            {
                moving = true;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving == true)
            {
                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.DrawRectangle(pen, e.X, e.Y, 3, 1);
                pictureBox1.Image = bitmap;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Image);

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Bitmap Image|*.bmp";
            saveDialog.Title = "Save Bitmap Image";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveDialog.FileName;

                // Choose the desired format (Bmp, Jpeg, Png, etc.)
                ImageFormat format = ImageFormat.Bmp;

                // Save the bitmap to the specified file path
                bitmap.Save(filePath, format);

                MessageBox.Show("Bitmap saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
