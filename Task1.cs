using System;
namespace SortApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] number = new int[10];
            Console.WriteLine("Введите 10 чисел");
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write("{0}-е число: ", i + 1);
                number[i] = Int32.Parse(Console.ReadLine());
            }
        
            
            int temp;
            for (int i = 0; i < number.Length-1; i++)
            {
                for (int j = i + 1; j < number.Length; j++)
                {
                    if (number[i] > number[j])
                    {
                        temp = number[i];
                        number[i] = number[j];
                        number[j] = temp;
                    }
                }
            }
             
            
            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }
            Console.ReadLine();

            
        }
    }
}