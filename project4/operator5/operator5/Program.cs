﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator5
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;

            Console.WriteLine(!(a != b)); //same as a == b
        }
    }
}
