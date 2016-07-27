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
        public T[] array;

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

            for (int c = 0; c < intArray.array.Length; c++)
            {
                intArray.setItem(c, c * 5);
                
            }

            for (int c = 0; c < intArray.array.Length; c++)
            {
                Console.Write(intArray.getItem(c) + " ");
                System.Threading.Thread.Sleep(500);
            }

            Console.WriteLine();
            Console.Read();

            MyGenericArray<char> charArray = new MyGenericArray<char>(5);

            for (int c = 0; c < charArray.array.Length; c++)
            {
                charArray.setItem(c, (char)(c + 97));
            }

            for (int c = 0; c < charArray.array.Length; c++)
            {
                Console.Write(charArray.getItem(c) + " ");
                System.Threading.Thread.Sleep(500);
            }

            
            Console.ReadKey();
        }
    }
}
