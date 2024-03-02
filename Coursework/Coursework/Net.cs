using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    class Net
    {
        public Byte[,] grid;
        public int Width;
        public int Height;
        public ArrayNet[] arrayNets;

        public Net(int height, int width)
        {
            Width = width;
            Height = height;
            int y=0;
            grid = new Byte[width,height];
            arrayNets = new ArrayNet[width*height];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    grid[i, j] = 0;
                    arrayNets[y] = new ArrayNet();
                    arrayNets[y].symbol = Convert.ToString((char)32);
                    arrayNets[y].symbolColor = Brushes.White;
                    arrayNets[y].backgroundColor = Brushes.Black;
                }
            }

        }
    }
}
