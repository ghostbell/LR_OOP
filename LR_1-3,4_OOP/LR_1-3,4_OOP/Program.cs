using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_1_3_4_OOP
{
    internal class Program
    {

        static (int, int, int, char) Function(int[] maxmin, string first_letter)
        {
            int max = 0;
            for (int i = 0; i < maxmin.Length; i++)
            {
                if (max < maxmin[i])
                {
                    max = maxmin[i];
                }
            }

            int min = 0;
            for (int i = 0; i < maxmin.Length; i++)
            {
                if (maxmin[i] < min)
                {
                    min = maxmin[i];
                }
            }

            int sum = 0;
            for (int i = 0; i < maxmin.Length; i++)
            {
                sum += maxmin[i];
            }

            Console.WriteLine($"Наибольший элемент массива: {max}");
            Console.WriteLine($"Наименьший элемент массива: {min}");
            Console.WriteLine($"Сумма элементов массива: {sum}");

            char symb = Convert.ToChar(first_letter.Substring(0, 1));
            Console.WriteLine(symb);

            (int, int, int, char) t = (max, min, sum, symb);
            return t;
        }

        static void Func_checked()
        {
            checked 
            {
                int a = int.MaxValue + 1;
            };
        }

        static void Func_unchecked()
        {
            unchecked 
            {
                int a = int.MaxValue + 1;
            };
        }

        static void Main(string[] args)
        {
            //--3a
            //int[,] array_matrix = { { 1, 2, 3 }, { 3, 2, 1 } };
            //int rows = array_matrix.GetLength(0);
            //int cols = array_matrix.GetLength(1);

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write($"{array_matrix[i, j]}  ");
            //    }
            //    Console.WriteLine();
            //}

            //--3b
            //string[] Months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            //for (int i = 0; i < Months.Length; i++)
            //{
            //    Console.WriteLine(Months[i]);
            //}
            //Console.WriteLine(Months.Length);

            //Console.WriteLine("Введите позицию элемента массива, который хотите изменить: ");
            //int indx = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите новое значение: ");
            //string new_elem = Console.ReadLine();

            //for (int i = 0; i < Months.Length; i++)
            //{
            //    if (i + 1 == indx)
            //    {
            //        Months[i] = new_elem;
            //    }
            //    Console.WriteLine(Months[i]);
            //}

            //--3c
            //float[][] numbers = new float[3][];
            //numbers[0] = new float[2];
            //numbers[1] = new float[3];
            //numbers[2] = new float[4];

            //Console.WriteLine("Вводите значения ступенчатого массива: ");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = 0; j < numbers[i].Length; j++)
            //    {
            //        numbers[i][j] = Convert.ToSingle(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("---------------------------------------");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = 0; j < numbers[i].Length; j++)
            //    {
            //        Console.Write(numbers[i][j] + "  ");
            //    }
            //    Console.WriteLine();
            //}

            //--3d
            //var sec_array = new[] {3, 5};
            //var smth = "ABCDEFGHI";
            //var char_array = new[] { 'a', 'b', 'c', 'd', 'e', 'f' };
            //var str_array = new[] { "ABC", "DEF", "GHI" };

            //--4a,b
            //(int, string, char, string, ulong) tuple = (4, "world", 'C', "something", 1234567890);
            //Console.WriteLine(tuple.ToString());
            //Console.WriteLine($"Tuple with elements: {tuple.Item1}, {tuple.Item3}, {tuple.Item4}");

            //--4c(1)
            //var t = ("post office", 3.6);
            //(string destination, double distance) = t;
            //Console.WriteLine($"Distance to {destination} is {distance} kilometers.");

            //--4c(2)
            //var t = ("post office", 3.6);
            //var (destination, distance) = t;
            //Console.WriteLine($"Distance to {destination} is {distance} kilometers.");

            //--4c(3)
            //var destination = string.Empty;
            //var distance = 0.0;

            //var t = ("post office", 3.6);
            //(destination, distance) = t;
            //Console.WriteLine($"Distance to {destination} is {distance} kilometers.");

            //--4c(4)
            //(var a, var b) = ("123", 456);
            //Console.WriteLine($"{a} {b}");

            //--4d
            //(int a, byte b) left = (5, 10);
            //(long a, int b) right = (5, 10);
            //Console.WriteLine(left == right);  // output: True
            //Console.WriteLine(left != right);  // output: False

            //var t1 = (A: 5, B: 10);
            //var t2 = (B: 5, A: 10);
            //Console.WriteLine(t1 == t2);  // output: True
            //Console.WriteLine(t1 != t2);  // output: False

            //--5
            int[] maxmin = { 11, 64, 4, 0, 90, -45 };
            string first_letter = "Long text";
            (int, int, int, char) tuple;

            tuple = Function(maxmin, first_letter);
            Console.WriteLine(tuple);

            Func_checked();
            Func_unchecked();
        }
    }
}
