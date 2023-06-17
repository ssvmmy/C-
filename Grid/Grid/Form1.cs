using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace Grid   {
    public partial class Form1 : Form    {
        Graphics g;

        public Form1()        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)        {
            pictureBox1.Width=this.Width-18; 
            pictureBox1.Height=this.Height-70;
        }

        private void Form1_Load(object sender, EventArgs e)        {
            //g=pictureBox1.CreateGraphics();
            pictureBox1.Width = this.Width-18;
            pictureBox1.Height = this.Height-70;
        }

        private void button1_Click(object sender, EventArgs e)        {
            g = pictureBox1.CreateGraphics();
            float Yresult = Int32.Parse(textBox2.Text);
            float Xresult = Int32.Parse(textBox1.Text);
            float abstandX = pictureBox1.Width / Xresult;
            float abstandY = pictureBox1.Height / Yresult;
            for (int y = 0; y <= Yresult; y++) g.DrawLine(Pens.Yellow, 0, y*abstandY, pictureBox1.Width, y*abstandY-1);           {
            for (int x = 0; x <= Xresult; x++) g.DrawLine(Pens.Yellow, abstandX*x, 0, x*abstandX, pictureBox1.Height);{
            }
            //g.FillRectangle(Brushes.Red, abstandX, abstandY, abstandX, abstandY);    
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            int sektorX;
            sektorX = e.X / (int)abstandX;
            int sektorY;
            sektorY = e.Y / (int)abstandY;
            g.FillRectangle(Brushes.Red, abstandX * sektorX, abstandY * sektorY, abstandX, abstandY);
            //MessageBox.Show(e.X.ToString() + "/" + e.Y.ToString());
            g.DrawString()
        }
    }
}
 