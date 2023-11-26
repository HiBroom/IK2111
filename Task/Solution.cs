// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
string[] arrayStrings1 = { "1235", "1500", "0000", "computer science" };
int board = 3;
int lengthOfNewArray = LengthOfNewArray(arrayStrings1);
string[] arrayStrings2 = new string[lengthOfNewArray];
string[] arrayStrings3 = GetNewArray(arrayStrings1);

int LengthOfNewArray(string[] arrayStrings1)
{
    int count = 0;
    for (int i = 0; i < arrayStrings1.Length; i++)
    {
        if (arrayStrings1[i].Length <= board)
        {
            count++;
        }
    }
    return count;
}
string[] GetNewArray(string[] arrayStrings1)
{
    int count = 0;
    for (int i = 0; i < arrayStrings1.Length; i++)
    {
        if (arrayStrings1[i].Length <= board)
        {
            arrayStrings2[count] = arrayStrings1[i];
            count++;
        }
    }
    return arrayStrings2;
}


void PrintArray(string[] arr)
{

    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}");
    Console.Write("]");
}
void PrintArray1(string[] arr)
{
    if (arrayStrings3.Length == 0)
    {
        Console.Write("[]");
    }
    else
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length - 1; i++)
        {
            Console.Write($"{arr[i]}, ");
        }
        Console.Write($"{arr[arr.Length - 1]}");
        Console.Write("]");
    }
}



PrintArray(arrayStrings1);
Console.Write("->");
PrintArray1(arrayStrings3);



