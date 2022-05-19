// Задача 1 Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

void Array(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
}

int EvenNumberArray(int[] arr2)
{
    int count = 0;
    for (int n = 0; n < arr2.Length; n++)
    {
        if (arr2[n] % 2 == 0)
        {
            count++;
        }
    }
    return (count);
}

void PrintArray(int[] arr2)
{
    for (int n = 0; n < arr2.Length; n++)
    {
        System.Console.Write(arr2[n] + " ");
    }
}

int[] array = new int[10];
Array(array);
PrintArray(array);
int count1 = EvenNumberArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Количество четных элементов в массиве равно {count1}");


