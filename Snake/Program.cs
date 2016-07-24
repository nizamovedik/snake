using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();
            Point p3 = new Point(0, 4, '^');
            p3.Draw();
            Point p4 = new Point(2, 5, '&');
            p4.Draw();

            HorizLine hLine = new HorizLine(4, 12, 7, '+');
            hLine.DrowHorizLine();

            VertLine vLine = new VertLine(15, 2, 8, '+');
            vLine.DrowVertLine();

            Console.ReadLine();
        }

    }
}
