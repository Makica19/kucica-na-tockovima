using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dan15kucicana_tockovima
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap b;
        int w, h;
        int px=50, py=200;
        bool desno = true;

       private void pictureBox1_Click(object sender, EventArgs e)
       {

       }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if(timer1.Enabled == true) timer1.Enabled = false;
            else timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (desno == true) px += 10;
            else px -= 10;
            g.Clear(Color.LightBlue);
            g.FillRectangle(Brushes.Green, 0, py + 160, w, py + 160);


            g.FillRectangle(Brushes.Blue, px, py, 150, 150);
            g.FillEllipse(Brushes.Black, px + 20, py + 130, 40, 40);
            g.FillEllipse(Brushes.Black, px + 150 - 20 - 40, py + 130, 40, 40);
            Pen olgu = new Pen(Color.Red, 3);
            g.DrawEllipse(olgu, px + 20, py + 130, 40, 40);
            g.DrawEllipse(olgu, px + 150 - 20 - 40, py + 130, 40, 40);

            Point[] niz = new Point[3];
            niz[0] = new Point(px - 15, py);
            niz[1] = new Point(px + 165, py);
            niz[2] = new Point(px + 75, py - 100);
            g.FillPolygon(Brushes.DarkRed, niz);
            g.DrawPolygon(olgu, niz);



            pictureBox1.Invalidate();
            if(px>w+100) desno=false;
            if(px<-250) desno=true;   
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            w = pictureBox1.Width;
            h = pictureBox1.Height;
            b = new Bitmap(w, h);
            pictureBox1.Image = b;
            g = Graphics.FromImage(b);
            g.Clear(Color.LightBlue);
            g.FillRectangle(Brushes.Green, 0, py+160, w, py+160);
           

            g.FillRectangle(Brushes.Blue, px, py, 150, 150);
            g.FillEllipse(Brushes.Black, px + 20, py + 130, 40, 40);
            g.FillEllipse(Brushes.Black, px + 150-20-40, py + 130, 40, 40);
            Pen olgu = new Pen(Color.Red, 3);
            g.DrawEllipse(olgu, px + 20, py + 130, 40, 40);
            g.DrawEllipse(olgu, px + 150 - 20 - 40, py + 130, 40, 40);

            Point[]niz=new Point[3];
            niz[0] = new Point(px - 15, py);
            niz[1] = new Point(px + 165, py);
            niz[2] = new Point(px + 75, py-100);
            g.FillPolygon(Brushes.DarkRed, niz);
            g.DrawPolygon(olgu, niz);



            pictureBox1.Invalidate();
        }
    }
}
