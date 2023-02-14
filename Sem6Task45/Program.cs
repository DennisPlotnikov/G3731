// Задача №45
// Напишите программу, которая будет создавать
// копию заданного одномерного массива с помощью
// поэлементного копирования.


// int[] Gen1DArr(int len, int b, int e)
// {
//     int[] arr = new int[len];

//     Random gen = new Random();

//     for (int i = 0; i < len; i++)
//     {
//         arr[i] = gen.Next(b, e);
//     }

//     return arr;
// }

// void Print1DArr(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + ",");
//     }
//     Console.WriteLine(arr[arr.Length - 1] + "]");
// }

// void ArrSort(int [] arr)
 
// {
// // int c;
// for (int i = 0; i < (arr.Length / 2); i++) 
// {
//         (arr[i], arr[arr.Length - 1 - i])=(arr[arr.Length - 1 - i], arr[i]);
//     }

// }

// // int len = ReadData("Введите длину массива: ");
// // int b = ReadData("Введите ниж диапазон: ");
// // int e = ReadData("Введите верх диапазон: ");
// int [] arr = Gen1DArr(5, 10, 99);
// Print1DArr(arr);
// ArrSort(arr);

// Print1DArr(arr);
