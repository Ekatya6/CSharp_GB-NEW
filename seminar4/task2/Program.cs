// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. 
// Использовать рекурсию. Например:
// 123 => 6,  63 => 9.


//---------------ОБЪЯВЛЕНИЕ ФУНКЦИЙ----------------

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int SumDigitsInNumber(int N)  // Сумма цифр в числе 
{
    if(N < 1) return 0;
    return N % 10 + SumDigitsInNumber(N / 10);
}

//---------------ОСНОВНОЙ КОД----------------------

int number = ReadInt("введите число: "); 
System.Console.WriteLine(SumDigitsInNumber(number));
