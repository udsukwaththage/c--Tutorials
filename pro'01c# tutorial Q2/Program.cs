﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_01c__tutorial_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("\nEnter a number:");
                number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    Console.Write("It's even");
                }
                else
                {
                    Console.Write("It's odd");
                }
            }
        }
    }
}
