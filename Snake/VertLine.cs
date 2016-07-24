using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class VertLine
    {
        List<Point> pList;

        public VertLine(int x, int yTop, int yBot, char sym)
        {
            pList = new List<Point>();
            for (int i = yTop; i <= yBot; i++)
            {
                Point p = new Point(x, i, sym);
                pList.Add(p);
            }
        }
        public void DrowVertLine()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
