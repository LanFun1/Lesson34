using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson34
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[0];
            string codeWord = " ";
            Console.WriteLine("Введите числа");
            while (true)
            {
                codeWord = Console.ReadLine();
                if(codeWord == "exit")
                {
                    break;
                }
                if (codeWord == "sum")
                {
                    int sum = 0;
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        sum += array[i];
                    }
                    Console.WriteLine("\nСумма: " + sum);
                }
                else if(Convert.ToInt32(codeWord)<=int.MaxValue)
                {
                    int[] tempArray = new int[array.GetLength(0)+1];
                    int elementCoordinate = 0;
                    foreach (int element in array)
                    {
                        tempArray[elementCoordinate] = element;
                        elementCoordinate++;
                    }
                    tempArray[tempArray.GetLength(0)-1] = Convert.ToInt32(codeWord);
                    array = tempArray;
                }
            }
        }
    }
}
