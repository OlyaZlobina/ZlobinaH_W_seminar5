// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] positivNumbersArray(int size)
{
    int[] Array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Array[i] = new Random().Next(100, 999);
    }
    return Array;
}

void evenNumbers(int[] Size)
{
    int count = 0;
    for (int i = 0; i < Size.Length; i++)
    {
        if(Size[i] % 2==0)
        {
            count++;
        }
    }
    Console.Write($" -> {count}");
}

void PrintPositivNumbersArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] Arr = positivNumbersArray(8);
PrintPositivNumbersArray(Arr);
evenNumbers(Arr);
Console.WriteLine();
