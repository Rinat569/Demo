using System;
  
    class MainClass {
      public static void Main (string[] args) {
          int chislo, len, c = 0;
            string str;
            
            
            int[] number = new int[10]
            {22,1,3,6,9,13,44,21,7,10};
        
            
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
            Console.Write("Введите число какое вы хотите проверть, находится ли он в массиве или нет: ");
            chislo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вы вели число: " + chislo + " ,теперь ищем есть ли это число в массиве!");
            bool flag = false;
            for(int i=0; i <number.Length;++i)
            {
                 if (number[i]==chislo)
                {
                    Console.WriteLine("Да ваше число совпадает с числом из массива!");
                    Console.WriteLine(number[i] + " = " + chislo);
                    flag = true;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Такого числа нет");
                return;
            }
            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }
            
            Console.ReadKey();
      }
    }