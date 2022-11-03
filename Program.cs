

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

string[] ArrayFormation(string[] _array, bool[] _arrayFlag)
{
    int newArraySize = 0;
    foreach (var item in _arrayFlag)
        if (item) newArraySize++;
    string[] newArray = new string[newArraySize];
    for (int i = 0, j = 0; i < _array.Length; i++)
    {
        if (_arrayFlag[i])
        {
            newArray[j] = _array[i];
            j++;
        }
    }
    return newArray;
}

void PrintArray(string[] _array)
{
    foreach (var item in _array)
    {
        Console.Write($"{item} ");
    }
}


