// Задача номер два. 
// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// Например: а = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// а = 9, b = -3, -> да 
// а = -3, иb = 9, -> нет.

 Console.WriteLine("Введите число");
 int num1  = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Введите число");
 int num2  = Convert.ToInt32(Console.ReadLine());

 if (num1 == num2*num2)
 {
  Console.WriteLine("Да");
 }
 else

 {
 Console.WriteLine("Нет");
 }
