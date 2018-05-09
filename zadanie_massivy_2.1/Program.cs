using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_massivy_2._1
{
    class Program
    {
        static int [] SubArray (int[] array, int index, int count)
        {
            int i = index;
            if (count < array.Length)
            {
                for (i = index; i <= array.Length - 1; i++)
                    Console.Write(array[i] + " ");
            }
            if (count >= array.Length)
            {
                int[] NewMassiv = new int[count+1];
                Array.Copy(array, NewMassiv, array.Length);
                for (i = index; i <= NewMassiv.Length - 1; i++)
                {
                    if (NewMassiv[i] == 0)
                    {
                        NewMassiv[i] = 1;
                    }
                    Console.Write(NewMassiv[i] + " ");
                }
            }
            return array;
            
        }

        static void Main()
        {
            int[] massiv = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
            SubArray(massiv, 0, 10);
            Console.ReadKey();
        }
    }
}
