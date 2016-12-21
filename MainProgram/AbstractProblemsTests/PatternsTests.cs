﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.AbstractProblems;

namespace Algorithms.MainProgram
{
    public class PatternsTests
    {
        public void TestTriangularPattern(int size)
        {
            //Testing to draw a pattern
            Patterns.PrintStar(size);
        }
        public void TestPrintMyNamesFirstCharacter(int size)
        {
            Patterns.PrintMyName(size);
        }
        public void TestPrintPyramid()
        {
            Console.Write("Pyramid Size : ");
            int t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Patterns.PrintPyramid(t);
            Console.ReadLine();
        }
    }
}
