// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// void RealArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0, 10);
//     }
// }
// double FindMax(double[] arr1)
// {
//     double Max = arr1[0];
//     for (int n = 0; n < arr1.Length; n++)
//     {
//         if (arr1[n] > Max)
//         {
//             Max = arr1[n];
//         }
//     }
//     return Max;
// }

// double FindMin(double[] arr1)
// {
//     double Min = arr1[0];
//     for (int n = 0; n < arr1.Length; n++)
//     {
//         if (arr1[n] < Min)
//         {
//             Min = arr1[n];
//         }
//     }
//     return Min;
// }

// void PrintRealArray(double[] arr2)
// {
//     System.Console.WriteLine("Дан массив:");
//     for (int i2 = 0; i2 > arr2.Length; i2++)
//     {
//         System.Console.WriteLine(arr2[i2]);
//     }
// }


//double[] array = new double[10];
//RealArray(array);
//PrintRealArray(array);
// double max = FindMax(array);
// double min = FindMin(array);
// double DiffMaxMin = max - min;
// System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {DiffMaxMin}");


//============================================================================================
// void NewArray(int[] Arr1)//Метод задания массива
// {
//     for (int count = 0; count < Arr1.Length; count++)
//     {
//         Arr1[count] = new Random().Next(0, 10);
//     }
// }

// void PrintNewArray(int[] Arr2)// Метод вывода массива
// {
//     for (int position = 0; position < Arr2.Length; position++)
//     {
//         System.Console.Write(Arr2[position] + " ");
//     }
// }
// int[] array = new int[10];
// NewArray(array);
// PrintNewArray(array);

// int FindMax(int[] arr1)
// {
//     int Max = arr1[0];
//     for (int n = 0; n < arr1.Length; n++)
//     {
//         if (arr1[n] > Max)
//         {
//             Max = arr1[n];
//         }
//     }
//     return Max;
// }

// int FindMin(int[] arr1)
// {
//     int Min = arr1[0];
//     for (int n = 0; n < arr1.Length; n++)
//     {
//         if (arr1[n] < Min)
//         {
//             Min = arr1[n];
//         }
//     }
//     return Min;
// }
// int Max = FindMax(array);
// int Min = FindMin(array);
// System.Console.WriteLine();
// System.Console.WriteLine(Max);
// System.Console.WriteLine(Min);
// int DiffMaxMin = Max - Min;
// System.Console.WriteLine(DiffMaxMin);
//=========================================================================================

// void NewArray(double[] Arr1)//Метод задания массива
// {
//     for (int count = 0; count < Arr1.Length; count++)
//     {
//         Arr1[count] = new Random().Next(0, 10);
//     }
// }

//double[] array = new double[] {1.5, 2.3, 3.0, 4.456, 5.789, 6.4521, 9.452, 5.6548};

void RealArray(double [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0,100) / 2.0; // для получения вещественного элемента нужно разделить 
        //на вещественное число обязательно через точку, даже если делим на 2, то писть нужно 2.0
    }
}

void PrintNewArray(double[] Arr2)// Метод вывода массива
{
    for (int position = 0; position < Arr2.Length; position++)
    {
        System.Console.Write(Arr2[position] + " ");
    }
}

double FindMax(double[] arr1)
{
    double Max = arr1[0];
    for (int n = 0; n < arr1.Length; n++)
    {
        if (arr1[n] > Max)
        {
            Max = arr1[n];
        }
    }
    return Max;
}

double FindMin(double[] arr1)
{
    double Min = arr1[0];
    for (int n = 0; n < arr1.Length; n++)
    {
        if (arr1[n] < Min)
        {
            Min = arr1[n];
        }
    }
    return Min;
}

double[] array = new double[10];
// NewArray(array);
RealArray(array);
PrintNewArray(array);
double Max = FindMax(array);
System.Console.WriteLine();
System.Console.WriteLine(Max);
double Min = FindMin(array);
System.Console.WriteLine(Min);
double DiffMaxMin = Max - Min;
System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {DiffMaxMin}");
