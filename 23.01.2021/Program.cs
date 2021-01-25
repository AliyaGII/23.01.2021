using System;

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
            Console.WriteLine(sum);
            Console.WriteLine();

            // B
            Console.WriteLine("Введите первое число");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int B = Convert.ToInt32(Console.ReadLine());
            for (int i = A + 1 % 2 == 1 ? A + 1 : A + 2; i < B; i = i + 2)
                Console.Write( i );
            Console.WriteLine();
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

            double init = 1000, 
            sum = 1000;
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
                while (sum < 1100)
                {
                    sum += (init * P) / 100;
                    k++;
                }
                string months;
                if (k == 1)
                {
                    month = "месяц";
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
                Console.WriteLine($"Итоговый размер вклада: {s} руб.\n");



                //Задание 2.1

                Console.Write("Введите размер массива: ");
                int N = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[N];
                for (int i = 0; i < arr.Length; i++)
                {
                    dz2_z1_arr[i] = i + 1;
                }
                int max = arr[0];
                int min = arr[0];
                int sum = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    max = Math.Max(max, arr[i]);
                    min = Math.Min(min, arr[i]);
                    sum += arr[i];
                }
                double aver = Convert.ToDouble(sum) / Convert.ToDouble(arr.Length);
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
                Console.WriteLine($"Общая сумма всех элементов: {sum}");
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


                    //Задание 2.2

                    int[] arr = new int[5];
            int l;

            Console.WriteLine("Enter five elements of the array: ");
            for (l = 0; l < 5; l++)
            {
                arr[l] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nYour array");
            for (l = 0; l < 5; l++)
            {
                Console.WriteLine(arr[l]);
            }

            Console.WriteLine("\nNew array in reverse order : ");
            for (l = 4; l >= 0; l--)
            {
                Console.WriteLine(arr[l]);
            }
            Console.ReadKey();

                     

                }
    }
}
