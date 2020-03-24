using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typeconversion5
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				string str = "true";
				bool b = Convert.ToBoolean(str);
				Console.WriteLine(b);
			}
			catch (Exception)
			{
				Console.WriteLine("this won't work");
			}
        }
    }
}
