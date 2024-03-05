// Вычислить значение формулы a * b : c + d, где a,b,c,d  - некторые целые числа. Решение оформить в виде функции. 
 double CalkulateFormula(int a, int b, int c, int d)
 {
    double numenator = a * b;                  // числитель
    int denomenator = c + d;                   // знаменатель
    double result = numenator / denomenator;
    return result;
 }

 double result = CalkulateFormula(1,2,3,4);    // когда мы Запускаем функцию, то используем термин Аргументы, если Создаем - то Параметры
System.Console.WriteLine(result);
