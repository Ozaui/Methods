using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hello();
            EnterYourName();
            Add(3, 8);
            Console.WriteLine(Impact(10, 5));
            Console.ReadLine();
        }
        static void Hello()
        {
            Console.WriteLine("Hello!");
        }
        static void EnterYourName()
        {
            string name = Console.ReadLine();
            Console.WriteLine(name);
        }
        static void Add(int n1, int n2) 
        {
            Console.WriteLine(n1 + n2);
        }

        static int Impact(int n1, int n2)
        {
            int result = n1 * n2;
            return result;
        }
    }
}
