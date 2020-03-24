using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typeconversion2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1000;                //cant use 1000 use 1 to around 255
            byte b =(byte)i;
            Console.WriteLine(b);
        }
    }
}
