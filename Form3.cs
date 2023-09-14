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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace FirstExercise4Class
{
    public partial class Form3 : Form
    {

        bool moving = false;
        Bitmap bitmap;
        Pen pen = new Pen(Color.Black, 5);
       

        public Form3()
        {
            InitializeComponent();
            //pictureBox1.Image = new Bitmap(@"C:\\Users\\michz\\Desktop\\Obra\\a.jpg");
            bitmap = new Bitmap(pictureBox5.Width, pictureBox5.Height);
            pen.Width = 9.0F;
           
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            //e.Graphics.FillRectangle(Brushes.Red, rectangle);
        }








        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pen.Color = pictureBox4.BackColor;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            pen.Color = pictureBox2.BackColor;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pen.Color = pictureBox3.BackColor;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //   using (var bmp = new Bitmap(panel1.Width, panel1.Height))
            //    {

            //        panel1.DrawToBitmap(bmp,new Rectangle(0,0,bmp.Width,bmp.Height));
            //        bmp.Save(saveFileDialog1.FileName + ".bmp");
            //    }
            //}
            saveFileDialog1.Filter = "JPEG image|*.jpg|Bitmap image|* .bmp";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = (FileStream)saveFileDialog1.OpenFile();
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        using (var bmp = new Bitmap(panel1.Width, panel1.Height))
                        {

                            panel1.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                            bmp.Save(fs, ImageFormat.Jpeg);
                        }

                        break;
                    case 2:
                        using (var bmp = new Bitmap(panel1.Width, panel1.Height))
                        {

                            panel1.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                            bmp.Save(fs, ImageFormat.Bmp);
                        }
                        break;
                }
                fs.Close();
            }
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
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

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving == true)
            {
                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.DrawRectangle(pen, e.X, e.Y, 3, 1);
                pictureBox5.Image = bitmap;
            }
        }

        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
        }
    }
}
