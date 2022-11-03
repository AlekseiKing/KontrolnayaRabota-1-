

string[] FillArray()
{
    int n;
    Console.Write("Введите число элементов массива: ");
    int.TryParse(Console.ReadLine()!, out n);
    string[] _array = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите {i + 1} элемент: ");
        _array[i] = Console.ReadLine()!;
    }
    return _array;
}



void PrintArray(string[] _array)
{
    foreach (var item in _array)
    {
        Console.Write($"{item} ");
    }
}


