using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            MyClass myClass = new MyClass(size);
            for (int i = 0; i < myClass.lenght; i++)
            {
                myClass[i]=int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < myClass.lenght; i++)
            {
                Console.WriteLine(myClass[i]);
            }
            Console.ReadLine();
        }
    }
}
