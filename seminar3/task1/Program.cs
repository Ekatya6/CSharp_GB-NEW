// Задайте массив символов (тип char []). Создайте строку из стмволов этого массива. 

char[] array = new char[]{'t', '4', '#', 'y', '9'};

string str ="";

for (int i = 0; i < array.Length; i++)
{
    str = str + array[i]; // чтобы преобразовать тип char в string надо или к str +, или char конвертировать в string
}

System.Console.WriteLine(str);
