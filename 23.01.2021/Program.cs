﻿using System;

namespace _23._01._2021
{
    class Program
    {
        static void Main()
        {
            //Задание 1.1

            // A
            Console.WriteLine("Введите первое число");
            int a_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b_1 = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = a_1 + 1; i < b_1; i++)
            {
                sum += i;
               
            }
            string comma = "";
            if (a_1 + 1 != b_1)
            {
                Console.WriteLine($"Нечетные числа между {a_1} и {b_1}:");
                for (int i = a_1 + 1; i <= b_1 - 1; i++)
                {
                    if (i % 2 == 1)
                    {
                       comma += i + ",";
                    }
                }
                comma = comma.Remove(comma.Length - 1, 1);
                Console.WriteLine(comma);
            }
            else
            {
                Console.WriteLine($"Нечетные между {a_1} и {b_1} нет чисел");
            }

            Console.WriteLine($"Сумма между числами {a_1} и {b_1}: {sum}");

            Console.WriteLine();
           

            


            //Задание 1.2

            // Прямоугольник

            for (int v = 1; v <= 5; v++)
            {
                for (int n = 1; n <= 15; n++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);
            Console.WriteLine();

            // Прямоугольный треугольник

            for (int v = 1; v <= 8; v++)
            {
                for (int n = 1; n <= v; n++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);
            Console.WriteLine();



            // Равносторонний треугольник

            int a = 1;
            int b = 5;
            int c = b - 1;

            for (int i = 0; i < b; i++)
            {
                for (int o = c; o > i; o--)
                {
                    Console.Write(" ");
                }
                for (int p = 0; p < a; p++)
                {
                    Console.Write("*");
                }
                a += 2;
                Console.WriteLine();
            }

            Console.ReadKey(true);



            // Ромб

            int s = 5;
            for (int i = s; i >= -s; i--)
            {
                for (int q = 1; q <= Math.Abs(i); q++)
                {
                    Console.Write(" ");
                }
                for (int t = s; t >= Math.Abs(i); t--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();





            //Задание 1.3

            double init = 1000, sum1 = 1000;
            int k = 0;

            wrong_input:
            Console.Write("Под каким процентом будет лежать вклад (1 - 24): ");
            double P = Convert.ToDouble(Console.ReadLine());

            if (P > 24)
            {
                Console.WriteLine("\nНе верный ввод");
                Console.WriteLine("Попробуйте заново\n");
                goto wrong_input;
            }

            if (P != 0)
            {
                while (sum1 < 1100)
                {
                    sum1 += (init * P) / 100;
                    k++;
                }
                string months;
                if (k == 1) 
                {
                    months = "месяц";
                }
                else if (k == 2 || k == 3 || k == 4)
                {
                    months = "месяца";
                }
                else
                {
                    months = "месяцев";
                }
                Console.WriteLine($"\nРазмер вклада превысит 1100 руб. за {k} {months}");
                Console.WriteLine($"Итоговый размер вклада: {sum1} руб.\n");
            }



            //Задание 2.1

            Console.Write("Введите размер массива: ");
                int N = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[N];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = i + 1;
                }
                int max = arr[0];
                int min = arr[0];
                int sum2 = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    max = Math.Max(max, arr[i]);
                    min = Math.Min(min, arr[i]);
                    sum2 += arr[i];
                }
                double aver = Convert.ToDouble(sum2) / Convert.ToDouble(arr.Length);
                int cnt = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        cnt++;
                    }
                }

                Console.WriteLine($"Наибольшее значение массива: {max}");
                Console.WriteLine($"Наименьшее значение массива: {min}");
                Console.WriteLine($"Общая сумма всех элементов: {sum2}");
                Console.WriteLine($"Среднее арифметическое всех элементов: {aver}");
                if (cnt > 0)
                {
                    Console.Write($"Все нечетные значения: ");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] % 2 != 0)
                        {
                            Console.Write(arr[i] + " ");
                        }
                    }
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine("В массиве нет нечетных элементов\n");
            }


            //Задание 2.2

  
            Console.Write("Введите размер массива: ");
            int arrN = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arrN];
            int[] arr_rev = new int[arrN];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите элемент массива индекса {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("");
            int j = array.Length - 1;
            for (int i = 0; i < array.Length; i++)
            {
                arr_rev[i] = array[j];
                j--;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Элемент инвертированного массива индекса {i + 1}: ");
                Console.WriteLine(arr_rev[i]);
            }
            Console.WriteLine("");



            //Задание 2.3

            Console.Write("Введите размер массива: ");
            int N1 = Convert.ToInt32(Console.ReadLine());
            int[] arr3 = new int[N];
            for (int i = 0; i < arr.Length; i++)
            {
                arr3[i] = i + 1;
            }
            Console.WriteLine("Ваш массив: ");
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i] + " ");
            }
            Console.Write("\nВведите целую переменную count: ");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите целую переменную index (с нуля): ");
            int index = Convert.ToInt32(Console.ReadLine());
            int[] new_arr = new int[count];

            for (int i = 0; i < count; i++)
            {
                if (i + index >= N1)
                {
                    new_arr[i] = 1;
                    continue;
                }
                new_arr[i] = arr3[i + index];
            }
            Console.WriteLine("Новый массив: ");
            for (int i = 0; i < new_arr.Length; i++)
            {
                Console.Write(new_arr[i] + " ");
            }

            Console.ReadKey();

        }
    }
}
