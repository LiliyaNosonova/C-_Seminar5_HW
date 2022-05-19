// Задача 2: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.

void NewArray(int[] arr1)
{
    for (int i1 = 0; i1 < arr1.Length; i1++)
    {
        arr1[i1] = new Random().Next(10);
    }
}

void PrintNewArray(int[] arr2)
{
    System.Console.WriteLine("Дан массив:");

    for (int i2 = 0; i2 < arr2.Length; i2++)
    {
        System.Console.Write(arr2[i2] + " ");
    }
}

void PrintOddIndexElements(int[] result)//Метод определения и вывода элементов массива, стоящих на нечетных местах
{
    System.Console.WriteLine();
    for (int i5 = 0; i5 < result.Length; i5++)
    {
        if (i5 % 2 == 1)
        {
            System.Console.WriteLine($"Позиция {i5} - Элемент {result[i5]}");
        }
    }
}
int SumOddArray(int[] res)
{
    int Sum = 0;
    for (int index = 0; index < res.Length; index++)
    {
        if (index % 2 == 1)
        {
            Sum = Sum + res[index];
        }
    }
    return Sum;
}

// void PrintIndexArray(int[] count)// Метод определения индексов массива
// {
//     System.Console.WriteLine();
//     System.Console.WriteLine("Номер элемента в массиве:");
//     for (int i3 = 0; i3 < count.Length; i3++)
//     {
//         System.Console.Write(i3 + " ");
//     }
// }

// void PrintOddArray(int[] odd)//Метод определения элементов, стоящих на неченых местах
// {
//     System.Console.WriteLine();
//     System.Console.WriteLine("Элементы, стоящие на нечетных позициях:");
//     for (int i4 = 0; i4 < odd.Length; i4++)
//     {
//         if (i4 % 2 == 1)
//         {
//             System.Console.Write(odd[i4] + " ");
//         }
//     }
// }
// ========================================================
int[] array = new int[10];
NewArray(array);
PrintNewArray(array);
//PrintIndexArray(array);
//PrintOddArray(array);
PrintOddIndexElements(array);
int Sum = SumOddArray(array);
System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {Sum}");




// Ниже разными способами пыталась вывести новый массив, 
//состоящий из элементов исходного массива, стоящих на неченых местах. Не получилось(
//int[] OddArray = array;
// void CreatNewArray(int[] arr2)
// {
//     int newi6 = 0;
//     for (int i6 = 0; i6 < arr2.Length; i6++)
//     {
//         if (i6 % 2 == 1)
//         {
//             newi6++;
//         }
//     }
// }
//CreatNewArray(array);
//PrintNewArray(OddArray);
// for (int newi6 = 0; newi6 < array.Length; newi6++)
// {
//     System.Console.Write(array[newi6] + " ");// Вывод элементов массива в строку через пробел
// }

//System.Console.WriteLine(OddArray[newi6]);
//OddArray[newi6] = OddArray

