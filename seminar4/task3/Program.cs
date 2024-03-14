// Считать строку с консоли, содержащую латинские буквы. Вывести на экран согласные буквы этой строки. 
// Использовать рекурсию, не использовать цикл. Например: 
// "hello" => h l l,  "world" =. r l d 

//---------------ОБЪЯВЛЕНИЕ ФУНКЦИЙ----------------

bool IsConsonant(char c)  // логический тип данных, "согласные"
{
    return "bcdfghjklmnpqrstvwxz".Contains(c); // метод Contains - если заданный символ в строке. c = 'l'
}

void PrintWithoutVowels(string str, int index = 0)  
{
    if (index >= str.Length) return;

    char c = char.ToLower(str[index]);

    if(IsConsonant(c))
    {
        System.Console.Write(str[index] + " ");
    }
    PrintWithoutVowels(str, index + 1);
}

//---------------ОСНОВНОЙ КОД----------------------

System.Console.WriteLine("введите строку");
string inputStr = Console.ReadLine();
PrintWithoutVowels(inputStr);   // здесь к аргументу можно добавить цифру строчки, откуда начать 
