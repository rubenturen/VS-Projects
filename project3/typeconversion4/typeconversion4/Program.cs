using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typeconversion4
{
    class Program
    {
        static void Main(string[] args)
        {
            try                      //use this when converting string to byte
            {
                string number = "1234";              //can't use words like "hey" to convert to numbers
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);

            }
            catch (Exception)
            {
                Console.WriteLine("number could not be converted to byte");
            }
        }
    }
}
