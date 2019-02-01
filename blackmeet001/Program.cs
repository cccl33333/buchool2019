using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackmeet001
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i <= 100; i++)
            
                Console.WriteLine(i.ToString().Replace("3", "A").Replace("5", "B").Replace("9", "C").Replace("0", "D"));
            
            Console.ReadLine();
        }
    }
}
// if (65 <= number && 90 >= number)
//                            System.Text.ASCIIEncoding asciiEncoding = new System.Text.ASCIIEncoding();
//byte[] btNumber = new byte[] { (byte)number };
//                    return asciiEncoding.GetString(btNumber);
