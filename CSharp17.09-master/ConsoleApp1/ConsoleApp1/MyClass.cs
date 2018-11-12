using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MyClass
    {
        public int lenght;
        public int[] arrayInt;
        public MyClass(int size)
        {
            lenght = size;
            arrayInt = new int[size];
        }
        public int this[int index]
        {
            set
            {
                arrayInt[index] = value*value;
            }
            get
            {
                return arrayInt[index];
            }
        }
    }
}
