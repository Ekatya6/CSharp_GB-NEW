// Напишите программу, которая выводит случайное число из отрезка (10, 99) и показывает наибольшую цифру числа.
// Например: 78 -> 8, или 12 -> 2, или 85 -> 8.

int num = new Random().Next(10,100);
System.Console.WriteLine(num);

int num1 = num/10;
int num2 = num%10;

if(num1>num2)
{
    System.Console.WriteLine(num1);
}
else if(num1==num2)
{
    System.Console.WriteLine("цифры равны");
}
else{
    System.Console.WriteLine(num2);
}
