using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SplitTest
{
    class Program
    {
        static void Main(string[] args)

        {

            //string[] year = commaDelimited.Split(new char[] { ',' });

            string str = "Mahmud|Rahman";

            string[] str1 = str.Split(new char[]{'|'});
            Console.WriteLine(str1[0]);

            Console.ReadKey();
        }
    }
}
