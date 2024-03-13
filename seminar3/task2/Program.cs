// На основе символов сторки (тип string) сформировать массив символов (тип char[]). Вывести массив на экран. 

string str = Console.ReadLine();
char[] array = new char[str.Length];

for (int i = 0; i< array.Length; i++)
{
    array[i] = str[i];
    System.Console.WriteLine(array[i]);
}