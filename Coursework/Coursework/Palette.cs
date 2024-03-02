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

        private void Palette_Load(object sender, EventArgs e)
        {
            int s = 9600;
            DataBank.arrayLetters = new char[224];
            for (int i = 0; i < 224; i++)
            {
                DataBank.arrayLetters[i] = (char)s;
                s++;
            }
            

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

        }

        private void dataGridSymbols_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBank.symbol = dataGridSymbols.CurrentCell.Value.ToString();
        }
    }
}
