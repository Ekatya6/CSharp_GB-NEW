// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа. 
// Например: 456 -> 46, или 782 -> 72, или 918 -> 98. 

int num = new Random().Next(100,1000); // 456
System.Console.WriteLine(num);

int result = num/100*10 + num%10;  // 4*10+ 6 + 46
System.Console.WriteLine(result);