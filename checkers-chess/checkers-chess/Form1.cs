using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkers_chess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int n;
        PictureBox[,] P;

        private void Form1_Load(object sender, EventArgs e)
        {
            n = 8;
            P = new PictureBox[n, n];
            int left = 2, top = 2;
            Color[] colors = new Color[] { Color.White, Color.Black };
            for (int i = 0; i < n; i++)
            {
                left = 2;
                if (i % 2 == 0)
                {
                    colors[0] = Color.Turquoise;
                    colors[1] = Color.DarkGreen;
                }
                else
                {
                    colors[1] = Color.Turquoise;
                    colors[0] = Color.DarkGreen;
                }

                for (int j = 0; j < n; j++)
                {
                    P[i, j] = new PictureBox();
                    P[i, j].BackColor = colors[(j % 2 == 0) ? 1 : 0];
                    P[i, j].Location = new Point(left, top);
                    P[i, j].Size = new Size(60, 60);
                    left += 60;
                    //black pieces
                      if( i ==1 ) { P[i, j].Image = Properties.Resources.pawn2; }
                    //white pieces
                       if( i == 6) { P[i, j].Image = Properties.Resources.pawn1;}
                    P[i, j].SizeMode = PictureBoxSizeMode.CenterImage;
                    
                    
                   
                    panel1.Controls.Add(P[i, j]);
                }
                top += 60;
            }

        }
    }
}
