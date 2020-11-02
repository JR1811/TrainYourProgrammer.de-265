using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGDS.DE.JanReichelt.Practice265
{   
    class Line
    {
        private int ax, ay, bx, by;
        private int lineHorizontal, deadLines;
        private int lengthOfLine = 30;


        public int Ax { get { return ax; }}
        public int Ay { get { return ay; } }
        public int Bx { get { return bx; } }
        public int By { get { return by; } }
        public int DeadLines { get { return deadLines; } }

        public Line (int xInput, int yInput, int horizontal)
        {
            lineHorizontal = horizontal;
            if (lineHorizontal == 1)
            {
                ax = xInput - lengthOfLine;
                bx = xInput + lengthOfLine;
                ay = yInput;
                by = yInput;
            }
            else
            {
                ax = xInput;
                bx = xInput;
                ay = yInput - lengthOfLine;
                by = yInput + lengthOfLine;
            }
        }

        bool intersects(int x, int y)
        {
            if (ax == x && ay == y)
            {
                return true;                
            }
            else if (bx == x && by == y)
            {
                return true;
            }

            else return false;
        }

        public Line createA(ArrayList others)
        {
            bool available = true;

            foreach(Line other in others)
            {
                if (other != this && other.intersects(ax, ay))
                {
                    available = false;
                    deadLines++;
                }
            }

            if (available)
            {
                return new Line(ax, ay, lineHorizontal * -1);   //invertieren der richtung
            }
            else { return null;  }
        }

        public Line createB(ArrayList others)
        {
            bool available = true;

            foreach (Line other in others)
            {
                if (other != this && other.intersects(bx, by))
                {
                    available = false;
                    deadLines++;
                }
            }

            if (available)
            {
                return new Line(bx, by, lineHorizontal * -1);   //invertieren der richtung
            }
            else { return null; }
        }
    }
}
