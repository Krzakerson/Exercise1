using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstExercise4Class
{
    public partial class Form2 : Form
    {

        string imagepath;
        Bitmap bitmap;
       
        bool paint = false;
        Point px, py;
        Pen pen = new Pen(Color.Black, 1);
        int index;
        public Form2(string value)
        {
           
            InitializeComponent();
           
            imagepath = value;  
            bitmap = new Bitmap(pictureBox1.Width,pictureBox1.Height);
           
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(imagepath);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (paint == true)
            {
                paint = false;
            }
            else
            {
                paint = true;
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint == true)
            {
                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.DrawRectangle(pen, e.X, e.Y, 3, 1);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1 != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {





                    pictureBox1.Image.Save(saveFileDialog.FileName);
                }
            }
            else
            {
                MessageBox.Show("There is not image to be save");
            }
        }
    }
}
