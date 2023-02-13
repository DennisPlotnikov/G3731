// №38 Задайте массив вещественных чисел. Найдите разницу между максимальным и
// минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6
// * Отсортируйте массив методом вставки и методом подсчета, а затем найдите
// разницу между первым и последним элементом. Для задачи со звездочкой
// использовать заполнение массива целыми числами.

// double[] Gen1DArr(int len, double b, double e)
// {
//     double[] arr = new double[len];

//     Random gen = new Random();

//     for (int i = 0; i < len; i++)
//     {
//         arr[i] = gen.NextDouble();
//     }

//     return arr;
// }

// void Print1DArr(double[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + ",");
//     }
//     Console.WriteLine(arr[arr.Length - 1] + "]");
// }

// void PrintData(string msg1, double msg2)

// {
//     Console.WriteLine(msg1);
//     Console.WriteLine(msg2);
// }

// double DiffElem(double [] arr)
// {
//     double res = 0;
//     res = arr.Max() - arr.Min();
//     return res;
// }


// double[] arr = Gen1DArr(5, 0.0, 1.0);

// double result = DiffElem(arr);

// Print1DArr(arr);
// PrintData("Разница мин макс:", result);



// Вариант со звездочкой


int[] Gen1DArr(int len, int b, int e)
{
    int[] arr = new int[len];

    Random gen = new Random();

    for (int i = 0; i < len; i++)
    {
        arr[i] = gen.Next(b, e);
    }

    return arr;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

void PrintData(string msg1, int msg2)

{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

int DiffElem(int[] intArray)
{
    int res = 0;
    int min = intArray[0];
    int max = intArray[intArray.Length-1];
    res = max-min;
    return res;
}



int[] ArrSort(int [] arr)
 
{
    int[] intArray = arr;
    Array.Sort(intArray);
     for (int i = 0; i < arr.Length; i++)
    {
        intArray[i] = intArray[i]++;
    }
    
       return intArray;
    }



int[] arr = Gen1DArr(5, 10, 99);
Print1DArr(arr);
ArrSort(arr);

int result = DiffElem(arr);

Print1DArr(arr);
PrintData("Разница мин макс:", result);