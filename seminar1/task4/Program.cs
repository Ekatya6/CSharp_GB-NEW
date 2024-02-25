// Задача номер четыре. 
// Напишите пограмму, которая на вход принимает одно число (N), а на выходе показывает все целые числав промежутке от -N до N.
// Например: 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4", или 2 -> "-2, -1, 0, 1, 2". 

 Console.WriteLine("Введите число");
 int num1  = Convert.ToInt32(Console.ReadLine());

 int negNum = num1 * -1;

 while(negNum<=num1)
 {
 Console.Write(negNum+ " ");
 negNum = negNum+1;
 } 
