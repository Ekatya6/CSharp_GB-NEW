﻿int n = 10;
int[]arr = new int[n];
int i = 0; // вводим счетчик, который начинаем с нуля

while (i<n)
{
    arr[i] = i + 1;
    //System.Console.Write(arr[i]);
    //System.Console.Write(' ');
    System.Console.Write($"{arr[i]} ");
    i = i + 1;
}
