// Создать программу, которая на вход принимает позиции элементов двумерного массива и возвращает значение этого элемента или указание, 
// что такого элемента нет.

internal class Program
{
    private static void Main(string[] args)
    {
        // ФУНКЦИИ 
        int ReadInt(string msg)
        {
            System.Console.Write(msg);
            return Convert.ToInt32(Console.ReadLine());
        }

        int[,] CreatArray(int row, int col, int leftRange, int rightRange)  // строка, столбец, границы генераций (диапазон)
        {
            int[,] tempArray = new int[row, col];
            Random rnd = new Random();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    tempArray[i, j] = rnd.Next(leftRange, rightRange + 1);
                }
            }
            return tempArray;
        }

        void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); ++i)
            {
                for (int j = 0; j < array.GetLength(1); ++j)
                {
                    System.Console.Write(array[i, j] + "\t");
                }
                System.Console.WriteLine();
            }
        }

        void InputNumber(int[,] array, int row, int col)
        {
            System.Console.Write(array[row, col]);
        }

        bool InputElementPosition(int[,] array, int col, int row)
        {

            if (!(row >= 0 && row < array.GetLength(0)) && col >= 0 && col < array.GetLength(1))
            {
                System.Console.WriteLine("элемент не совпадает по строкам и по столбцу одновременно");
                return false;
            }
            else if (row > array.GetLength(0) - 1 || row < 0)
            {
                System.Console.WriteLine("позиция по строкам выходит за пределы массива");
                return false;
            }
            else if (col > array.GetLength(1) - 1 || col < 0)
            {
                System.Console.WriteLine("позиция по столбцам выходит за пределы массива");
                return false;
            }
            return true;
        }

        // ОСНОВНОЙ КОД 

        int row = ReadInt("введите количестао строк");
        int column = ReadInt("введите количество столбцов");

        System.Console.WriteLine("массив");

        int[,] array = CreatArray(row, column, 0, 100);
        PrintArray(array);

        int row2 = ReadInt("введите номер строки") - 1;
        int column2 = ReadInt("введите номер столбца") - 1;

        if (InputElementPosition(array, column2, row2))
        {
            InputNumber(array, row2, column2);
        }
    }
}