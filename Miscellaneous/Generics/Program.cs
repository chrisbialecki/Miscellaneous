using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{

    public class MyGenericArray<T>
    {
        //declare generic private array
        private T[] array;

        //construcor + instance of array
        public MyGenericArray(int size)
        {
            array = new T[size + 1];
        }

        //method generic getItem
        public T getItem(int index)
        {
            return array[index];
        }

        //method setItem
        public void setItem(int index, T value)
        {
            array[index] = value;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyGenericArray<int> intArray = new MyGenericArray<int>(5);

            for (int c = 0; c < 5; c++)
            {
                intArray.setItem(c, c * 5);
            }

            for (int c = 0; c < 5; c++)
            {
                Console.Write(intArray.getItem(c) + " ");
            }

            Console.WriteLine();
        }
    }
}
