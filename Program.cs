using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_Arrays
/*
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int[] array = new int[10]; // Створив масив з 10 елементів

            for (int i = 0; i < array.Length; i++) // Заповнення масиву випадковими числами від -10 до 10
            {
                array[i] = rand.Next(-10, 11); 
            }

            Console.WriteLine("Усі елементи масиву:");
            foreach (int value in array)
                Console.Write("{0,5}", value);
            Console.WriteLine();

            Console.WriteLine("Елементи з парними індексами:");
            for (int i = 0; i < array.Length; i += 2)
                Console.Write("{0,5}", array[i]);

            // Обчислення суми елементів масиву (Завдання 2)
            int sum = 0;
            foreach (int value in array)
            {
                sum += value;
            }
            
            Console.WriteLine($"\nСума елементів масиву: {sum}");
            
            // Перевірка, чи є сума невід'ємною
            if (sum >= 0)
            {
                Console.WriteLine("Сума елементів масиву є невід'ємною.");
            }
            else
            {
                Console.WriteLine("Сума елементів масиву є від'ємною.");
            }
            Console.ReadLine();
        }
    }
}
*/
/*
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] multiplicationTable = new int[9, 9];

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    multiplicationTable[i, j] = (i + 1) * (j + 1);
                }
            }

            Console.WriteLine("Таблиця множення 9x9:");

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write($"{multiplicationTable[i, j],3} ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
*/
/*
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5];
            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = rand.Next(-50, 51);
                }
            }

            Console.WriteLine("Двовимірний масив 5x5:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{array[i, j],5} ");
                }
                Console.WriteLine();
            }

            int max = array[0, 0];
            int min = array[0, 0];
            int maxRow = 0, maxCol = 0;
            int minRow = 0, minCol = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        maxRow = i;
                        maxCol = j;
                    }

                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        minRow = i;
                        minCol = j;
                    }
                }
            }

            Console.WriteLine($"\nМаксимальний елемент: {max} (рядок {maxRow + 1}, стовпець {maxCol + 1})");
            Console.WriteLine($"Мінімальний елемент: {min} (рядок {minRow + 1}, стовпець {minCol + 1})");

            Console.ReadLine();
        }
    }
}
*/

{
    enum DaysOfWeek
    {
        Monday,     // 0
        Tuesday,    // 1
        Wednesday,  // 2
        Thursday,   // 3
        Friday,     // 4
        Saturday,   // 5
        Sunday      // 6
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть кількість днів: ");
            int days;

            while (!int.TryParse(Console.ReadLine(), out days) || days < 0)
            {
                Console.Write("Некоректне значення. Введіть додатне число: ");
            }

            DaysOfWeek resultDay = (DaysOfWeek)(days % 7);

            Console.WriteLine($"\nЧерез {days} днів буде: {resultDay}");

            Console.ReadLine();
        }
    }
}