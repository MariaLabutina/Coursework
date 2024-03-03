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
    public partial class Palette : Form
    {
        public Palette()
        {
            InitializeComponent();
        }
        Graphics g;
        Brush[] color;
        private void Palette_Load(object sender, EventArgs e)
        {
            Bitmap btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            int cellsize = pictureBox1.Width / 6;
            Net net = new Net(pictureBox1.Width / cellsize, pictureBox1.Height / cellsize);
            int s = 9600;
            DataBank.arrayLetters = new char[224];
            for (int i = 0; i < 224; i++)
            {
                DataBank.arrayLetters[i] = (char)s;
                s++;
            }

            int d = 0;
            int c = 25;
            int l = 0;
            int r = DataBank.arrayLetters.Length / c+1;
            for(int i=0; i<c; i++)
            {
                dataGridSymbols.Columns.Add(i.ToString(), "0");
                dataGridSymbols.Columns[i].Width = 15;
            }
            dataGridSymbols.Columns[c].Width = 15;
            for(int i=0; i<r; i++)
            {
                dataGridSymbols.Rows.Add();
                for(int j=0; j<c+1; j++)
                {
                    if (l < 224)
                    {
                        char tmp = DataBank.arrayLetters[l];
                        dataGridSymbols[j, i].Value = tmp;
                        l++;
                    }

                }
            }
            color = new Brush[16] { Brushes.Black, Brushes.DarkGray, Brushes.RoyalBlue, Brushes.Blue, Brushes.DarkGreen, Brushes.Green, Brushes.DarkCyan, Brushes.Cyan, Brushes.DarkRed, Brushes.Red, Brushes.DeepPink, Brushes.Coral, Brushes.Orange, Brushes.Yellow, Brushes.LightGray, Brushes.White };
            g = Graphics.FromImage(btm);
            for(int i=0; i< pictureBox1.Width / cellsize; i++)
            {
                for(int j=0; j<pictureBox1.Height/cellsize; j++)
                {
                    if (d < 16)
                    {

                    g.FillRectangle(color[d], i * cellsize, j * cellsize, cellsize, cellsize);
                    d++;
                    }
                }
            }
            pictureBox1.Image = btm;
        }

        private void dataGridSymbols_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBank.symbol = dataGridSymbols.CurrentCell.Value.ToString();
        }
    }
}
