using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap btm = new Bitmap(100,100);
        Graphics g;
        Net net ;
        string s = "1";
        int cellsize;
        int Height;
        int Widht;

        Font font;
        private void Form1_Load(object sender, EventArgs e)
        {
            Height = pictureBox1.Height;
            Widht = pictureBox1.Width;
            btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            cellsize = pictureBox1.Height / 50;
            net = new Net(Height/cellsize ,  Width/cellsize);
            font = new Font("Consolas", cellsize, GraphicsUnit.Pixel);
            Console.WriteLine(cellsize);
            Console.WriteLine(font.Size);
           
            DataBank.symbol = Convert.ToString((char)100);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            int c;
            if (e.X / cellsize > 0 && e.X / cellsize < net.Width && e.Y / cellsize > 0 && e.Y / cellsize < net.Height)
            {
                if (e.Button == MouseButtons.Left)
                {
                    net.grid[e.X / cellsize, e.Y / cellsize] = 1;
                    c = (e.X / cellsize)* Height / cellsize+ e.Y / cellsize;

                    net.arrayNets[c].symbol = DataBank.symbol;
                }
                
                Draw();
            }

        }

        private void Draw()
        {
            g = Graphics.FromImage(btm);
            g.Clear(Color.Black);
            int c;
            for(int i=0; i< Width / cellsize-1; i++)
            {
                for(int j=0; j<Height/cellsize; j++)
                {
                    if(net.grid[i, j] == 1)
                    {
                        c = i * Height / cellsize + j;
                        g.FillRectangle(net.arrayNets[c].backgroundColor, i*cellsize, j*cellsize,cellsize, cellsize);
                        g.DrawString(net.arrayNets[c].symbol, font, net.arrayNets[c].symbolColor, i * cellsize, j * cellsize);
                    }
                   
                }
            }
            
            pictureBox1.Image = btm;
        }
        Palette palette = new Palette();
        private void button1_Click(object sender, EventArgs e)
        {
            palette.ShowDialog();
        }
    }
}
