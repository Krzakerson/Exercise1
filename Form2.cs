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
        public Form2(string value)
        {
            InitializeComponent();
            imagepath = value;  
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(imagepath);
        }
    }
}
