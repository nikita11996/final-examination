Console.WriteLine("Введите строки для массива через запятую:");
// Считывается введенная строка с консоли и разбивается на массив строк по запятой
string[] initialArray = Console.ReadLine().Split(',');

// Фильтруется начальный массив строк по длине <= 3
string[] newArray = FilterArrayByLength(initialArray, 3);

// Выводится на экран новый массив строк
Console.WriteLine("Новый массив строк с длиной меньше или равной 3 символам:");
foreach (string str in newArray)
{
   Console.Write(string.Join(", ", str + " "));
}

string[] FilterArrayByLength(string[] array, int maxLength)
{
    // Подсчитывается количество строк в массиве, удовлетворяющих условию
    int count = 0;
    foreach (string str in array)
    {
        if (str.Length <= maxLength)
        {
            count++;
        }
    }

    // Создается новый массив из строк подходящей длины
    string[] result = new string[count];
    int i = 0;
    foreach (string str in array)
    {
        if (str.Length <= maxLength)
        {
            result[i] = $"\"{str}\"";
            i++;
        }
    }

    return result;
}
