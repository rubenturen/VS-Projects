using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typeconversion3
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "1234";              //can't use words like hey to convert to numbers
            int i = Convert.ToInt32(number);
            Console.WriteLine(i);
        }
    }
}
