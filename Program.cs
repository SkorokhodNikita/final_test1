Console.Clear();

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] stringArr = new string[size];

void GetElement(string[] stringArr)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1}-й элемент: ");
        stringArr[i] = Console.ReadLine()!;
    }
}

string[] NewArray(string[] stringArr)
{
    int newSize = 0;
    for (int i = 0; i < stringArr.Length; i++)
    {
        if (stringArr[i].Length <= 3)
        {
            newSize++;
        }
    }
    string[] newStringArr = new string[newSize];
    int j = 0;
    for (int i = 0; i < stringArr.Length; i++)
    {
        if (stringArr[i].Length <= 3)
        {
            newStringArr[j] = stringArr[i];
            j++;
        }
    }
    return newStringArr;
}

void PrintArray(string[] newStringArr)
{
    Console.Write("[");
    Console.Write(string.Join(", ", newStringArr));
    Console.Write("]");
}

GetElement(stringArr);
PrintArray(stringArr);
Console.Write(" -> ");
PrintArray(NewArray(stringArr));