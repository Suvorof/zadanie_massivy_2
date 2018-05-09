using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_massivy_2
{
    class Program
    {
        static void MyReverse (int[] array)
        {
            Console.WriteLine ("Вывод элементов массива в обртаном порядке:");
            for (int i = array.Length - 1; i >= 0; i--)
                Console.Write (array[i]+ " ");
        }
               

        static void Main()
        {
            int[] massiv = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
            MyReverse(massiv);
            Console.ReadKey();                       
        }
    }
}
