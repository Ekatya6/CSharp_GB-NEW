// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// Например: 14 -> нет, 46 -> нет, 161 -> да.

System.Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());

if(num%7 ==0 && num%23 ==0)         // && (два амперсанта) - для условия И  || (два верт. слэша) - для условия ИЛИ
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}