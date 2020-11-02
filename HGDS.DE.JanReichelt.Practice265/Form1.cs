using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HGDS.DE.JanReichelt.Practice265
{

    /*
       Fuer eine vereinfachte Version in der Processing Umgebung (aehnlich zu vereinfachtes Java):
       https://thecodingtrain.com/CodingChallenges/126-toothpicks.html
    */

    public partial class Frm_Practice265 : Form
    {
        int canvasMidX, canvasMidY, deadEnd = 0;
        ArrayList picks = new ArrayList();

        public Frm_Practice265()
        {
            InitializeComponent();

            canvasMidX = pnl_canvas.Size.Width / 2;
            canvasMidY = pnl_canvas.Size.Height / 2;

            pnl_canvas.Refresh();
        }

        private void cmd_step_Click(object sender, EventArgs e)
        {
            if (picks.Count <= num_maxCount.Value)
            {
                pnl_canvas.Refresh();                
                
            }
        }

        private void pnl_canvas_Paint(object sender, PaintEventArgs e)
        {
            if (picks.Count <= num_maxCount.Value)
            {
                Pen linePen = new Pen(Color.Black, 2);
                Pen pointPen = new Pen(Color.Black, 1);
                Setup();
                Draw(linePen, e);
            }            
        }

        //Methoden
        void Setup()
        {
            picks.Add(new Line(0, 0, 1));
        }

        void Draw(Pen linePen, PaintEventArgs e)
        {

            foreach (Line t in picks)
            {
                e.Graphics.DrawLine(linePen, t.Ax + canvasMidX, t.Ay + canvasMidY, t.Bx + canvasMidX, t.By + canvasMidY);
                this.Text = $"{t.DeadLines} Freie Spitzen";

            }

            ArrayList next = new ArrayList();
            foreach (Line t in picks)
            {
                Line nextA = t.createA(picks);
                Line nextB = t.createB(picks);

                if (nextA != null)
                {
                    next.Add(nextA);
                }
                else { deadEnd++; }

                if (nextB != null)
                {
                    next.Add(nextB);
                }
                else { deadEnd++; }
            }

            picks.AddRange(next);
        }
    }
}
