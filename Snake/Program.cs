﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 3;
            int y1 = 5;
            char sym1= '*';
            Draw(x1, y1, sym1);
            Console.ReadLine();


        }
        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
