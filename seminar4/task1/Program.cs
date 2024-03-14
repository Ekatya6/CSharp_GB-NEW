//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. 
// Испльзовать рекурсию, не использовать цикл. Например: 
//  N=5 => 1 2 3 4 5 

//---------------ОБЪЯВЛЕНИЕ ФУНКЦИЙ----------------
int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumbers(int N)       // 7 -> 6 -> 5 -> 4 -> 3 -> 2 -> 1
{
    if(N < 1) return;          // Условие остановки рекурсии                     
    PrintNumbers(N - 1);   
    System.Console.Write(N + " ");
}

//---------------ОСНОВНОЙ КОД----------------------
int number = ReadInt("введите число: ");
PrintNumbers(number);

