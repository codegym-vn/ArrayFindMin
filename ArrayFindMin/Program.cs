using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFindMin
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] arrayStored = new int[20];
            int length = arrayStored.Length;
            Console.WriteLine("Enter elements in array:");
            for (i = 0; i < length; i++)
            {
                Console.Write("Element[{0}]: ", i);
                arrayStored[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\n");
            Console.WriteLine("The elements stored in the array are: ");
            for (i = 0; i < length; i++)
            {
                Console.Write("{0} ", arrayStored[i]);
            }
            int minValue = arrayStored.Min();
            Console.Write("\n");
            Console.WriteLine("Min value: {0} ", minValue);
            Console.ReadKey();
        }
    }

}
