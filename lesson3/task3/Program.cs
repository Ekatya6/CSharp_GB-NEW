// Создаем функцию, которая изменяет элементы массива - например, обнулит четные элементы массива.  

void ZeroEvenElements(int[] arr)   // функция называется ОбнулениеЧетныхЭлементов
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}

void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        System.Console.Write($"{e} ");
    }
}

int[] array = { 1, 2, 3, 4, 5 };
ZeroEvenElements(array);
PrintArray(array);
