// Задайте двумерный массив из целых чисел. Сформируйте новый одномерный массив, состоящий из средних арифметических значений 
// по строкам двумерного массива. 
// Например: 
// 2 3 4 3 
// 4 3 4 1 => [3 3 5]
// 2 9 5 4 

int[,] array = new int[4,5];
double[] array2 = new double[array.GetLength(0)];  // меняем переменную на double, чтобы учитывались и нецелые числа (десятки)

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
GetCountNumberInArray();     
System.Console.WriteLine();        
PrintArray2();


void GetCountNumberInArray()             
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }

        array2[1] = sum/ array.GetLength(1);  
    }
}

void PrintArray2()
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            System.Console.Write(array2[i]+ " ");
        }  
}
