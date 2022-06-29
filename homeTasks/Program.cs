// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] positivNumbersArray(int size)
// {
//     int[] Array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Array[i] = new Random().Next(100, 999);
//     }
//     return Array;
// }

// void evenNumbers(int[] Size)
// {
//     int count = 0;
//     for (int i = 0; i < Size.Length; i++)
//     {
//         if(Size[i] % 2==0)
//         {
//             count++;
//         }
//     }
//     Console.Write($" -> {count}");
// }

// void PrintPositivNumbersArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// int[] Arr = positivNumbersArray(8);
// PrintPositivNumbersArray(Arr);
// evenNumbers(Arr);
// Console.WriteLine();


// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19

// int[] ArrayOfNumbers(int length)
// {
//     int[] array = new int [length];
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = new Random().Next(1, 20);
//     }
//     return array;
// }

// void SummOfNumbersNotEvenPosition(int[] size)
// {
//     int summ = 0;
//     for (int i = 1; i < size.Length; i+=2)
//     {
//         summ = summ + size[i];
//     }
//     Console.Write($" -> {summ}");
// }

// void ShowArrayOfNumbers(int[] Arr)
// {
//     for (int i = 0; i < Arr.Length; i++)
//     {
//         Console.Write(Arr[i] + " ");
//     }
// }
// int[] myArray = ArrayOfNumbers(8);
// ShowArrayOfNumbers(myArray);
// SummOfNumbersNotEvenPosition(myArray);
// Console.WriteLine();