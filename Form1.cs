using System.IO;
using System.Windows.Forms;

namespace FirstExercise4Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }
       
        

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
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ext = Path.GetExtension(openFileDialog1.FileName);

                if(ext == ".jpg" || ext ==  ".png" || ext == ".jpeg")
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
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string folder = folderBrowserDialog.SelectedPath;
                string[] files = Directory.GetFiles(folder);


                int manyoffile = files.Length;

                MessageBox.Show(manyoffile.ToString());
            }
        }
    }
}