// Считато строку с консоли, состоящую из латинских букв в нижнем регистре. Выяснить, сколько исреди введенных букв гласных.  
// Например: 
// "hello" => 2
// "world" => 1 

System.Console.WriteLine("введите строчку");
string userInput = Console.ReadLine();

string vowels = "aeiud";   // vowels - гласные
int count = 0;

foreach (var e in userInput)
{
    if (vowels.Contains(e))    // функция Contains говорит нам, есть ли в этой строчке какой-то символ
    {
        count++;
    }
}
System.Console.WriteLine(count);