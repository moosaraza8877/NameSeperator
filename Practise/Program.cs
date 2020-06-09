using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            Console.Write("Enter your name: ");
            a = Console.ReadLine();
            int i = a.IndexOf(' ');
            int j = a.IndexOf(' ', i + 1);
            Console.WriteLine("First name: " + a.Substring(0, i));
            Console.WriteLine("Second name: " + a.Substring(i + 1, j - i));
            Console.WriteLine("Third name: " + a.Substring(j));
        }
    }
}
