using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80,35);
            Console.SetWindowSize(80, 35);
            HorizLine hLineTop = new HorizLine(0, 78, 0, '+');
            
            HorizLine hLineBot = new HorizLine(0, 78, 34, '+');
           
            VertLine vLine = new VertLine(0, 0, 34, '+');
            
            VertLine vLine2 = new VertLine(78, 0, 34, '+');
            hLineTop.DrowLine();
            hLineBot.DrowLine();
            vLine.DrowLine();
            vLine2.DrowLine();

            Point p = new Point(10, 3, '*');
            Snake snake = new Snake(p, 10, Direction.RIGHT);
            snake.DrowLine();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(200);
                snake.Move();
            }
        }

    }
}
