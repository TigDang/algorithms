using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;



namespace Massive_sort_and_binary_search
{
    class Program
    {
        static int validate()
        {
            int k;
            string input = Console.ReadLine();
            while (!Int32.TryParse(input, out k))
            {
                Console.WriteLine("Пожалуйста, введите значение в числовом формате.");
                Console.Write("_");
                input = Console.ReadLine();
            }
            return k;
        }
        static void Main(string[] args)
        {
            int value, arrScale;
            //Регулировка массива:
            Console.WriteLine("Введите количество ячеек массива:");
            Console.Write("_");
            arrScale = validate();
            int[] arr = new int[arrScale];
            
            
            //Bвод искомого:
            Console.WriteLine("Введите искомое число:");
            Console.Write("_");
            value = validate();


            //Заполнение массива:
            Console.WriteLine("Заполните массив:");               
            for (int i = 0; i < arrScale; i++)
            {
                arr[i] = validate();
                
            }


            //Сортировка массива и его вывод:
            Array.Sort(arr);
            Console.WriteLine("Отсортированный:");
            for (int i = 0; i < arrScale; i++)
            {
                Console.WriteLine("[{0}] = {1}", i, arr[i]);
                Thread.Sleep(100);
            }

            Console.WriteLine(BinarySearch(arr,value) + "- индекс искомого");
            Console.ReadKey();
        }
        static int BinarySearch(int[] arr, int value)
        {
            int high = arr.Length, low = 0;
            while (arr[(high - low) / 2] != value)
            {
                if (arr[(high - low) / 2] > value)
                {
                    high = (high - low) / 2;
                }
                else if (arr[(high - low) / 2] < value)
                {
                    low = (high - low) / 2;
                }
                else
                {
                    break;
                }
            }
            return (high - low) / 2;
        }
    }
}
