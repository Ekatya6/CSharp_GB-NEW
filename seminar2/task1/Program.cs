// Задайте двумерный массив. Найдите элементы, у которых оба индекса четные, и замените эти элементы на их квадраты. 
// Например: 
// 2 3 4 3 
// 4 3 4 1 => 
// 2 9 5 4 
// Обсудить и оформить этапы решения задачи в виде функций (создание, заполнение и вывод массива)
// 4 3 16 3 
// 4 3 4 1 
// 4 9 25 4 

using System.Security.Principal;

int[,] array = new int[4,5];

void FillingArray()
{
    for (int i = 0; i < array.GetLength(0); i++)   // Два цикла (внешний и внутренний) нужны для прохождения по всем элементам строки и столбца
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j]= new Random().Next(1,10);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j]+ " ");
        }
        System.Console.WriteLine();   // пустой для того, чтобы перейти на новую строчку
    }
}

FillingArray();                         // заполняем массив 
PrintArray();                           // выводим массив 
ChangeArray();                          // меняем массив 
System.Console.WriteLine();             //
PrintArray();                           // чтобы снова вывести уже измененный массив

void ChangeArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           if(i %2 ==0 & j %2 ==0)
           {
            array[i,j] = array[i,j]* array[i,j];
           }
        }
        System.Console.WriteLine();   // пустой для того, чтобы перейти на новую строчку
    }
}