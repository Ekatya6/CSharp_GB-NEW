//  Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0), (1,1) и тд)

int[,] array = new int[4,5];

void FillingArray()
{
    for (int i = 0; i < array.GetLength(0); i++)  
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
        System.Console.WriteLine();   
    }
}

FillingArray();                         
PrintArray();                                                     
System.Console.WriteLine(GetCountNumberInArray());             


int GetCountNumberInArray()              // меняем переменную на int, потому что будет целое число, с которым будем работать
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           if(i == j)
           {
            sum = sum + array[i,j];
           }
        }
        System.Console.WriteLine();   // пустой для того, чтобы перейти на новую строчку
    }
    return sum;
}