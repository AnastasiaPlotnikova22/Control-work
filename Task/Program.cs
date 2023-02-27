// Задача. Написать программу, которая из имеющегося массива строк формирует массив из строк
// длинна которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старрте выполнения алгоритма.При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []


Console.WriteLine("Введите массив строк через пробел");
string stroka = Console.ReadLine();
string[] array = stroka.Split(' ');

string[] GetShortArray(string[] array)
{
    var result = new string[array.Length];
    var count = 0;
    for (int i = 0; i < array.Length; i++)
    if (array[i].Length <= 3)
    {
        result[count] = array[i];
        count++;
    }
    return result;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Исходный массив:");
PrintArray(array);
string[] shortArray = GetShortArray(array);
Console.WriteLine($"Массив который > = 3");
PrintArray(shortArray);
