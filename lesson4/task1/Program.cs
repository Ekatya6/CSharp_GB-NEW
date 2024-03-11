// Создать двумерный массив с размерами 3 х 5, состоящий из целых чисел. Вывести его элементы на экран.

using System;
class Program
{
    static void Main()
    {
        int[,] array = new int[3, 5];
        Random rnd = new Random();

        for (int i = 0; i < 3; i++)      // если мы указываем нулевое измерение, то мы запрашиваем количество строк, i - строка
        {
            for (int j = 0; j < 5; j++)  // (1) - запрашиваем количество столбцов в этом массиве, j - столбец

            {
                array[i, j] = rnd.Next(1, 11);
            }
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                System.Console.Write(array[i, j] + " ");
            }
            System.Console.WriteLine();
        }
    }

}