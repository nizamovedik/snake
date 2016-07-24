using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class HorizLine
    {
        List<Point> pList;

        public HorizLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for (int i = xLeft; i <= xRight; i++)
            {
                Point p = new Point(i, y, sym);
                pList.Add( p );
            }
        }
        public void DrowHorizLine()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
