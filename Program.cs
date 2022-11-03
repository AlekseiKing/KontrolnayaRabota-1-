

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

bool[] FindInText(string[] _array)
{
    bool[] arrayFlag = new bool[_array.Length];
    for (int i = 0; i < _array.Length; i++)
    {
        if (_array[i].Length <= 3)
        {
            arrayFlag[i] = true;
        }
        else arrayFlag[i] = false;
    }
    return arrayFlag;
}

void PrintArray(string[] _array)
{
    foreach (var item in _array)
    {
        Console.Write($"{item} ");
    }
}


