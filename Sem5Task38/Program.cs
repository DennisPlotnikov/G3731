// №38 Задайте массив вещественных чисел. Найдите разницу между максимальным и
// минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6
// * Отсортируйте массив методом вставки и методом подсчета, а затем найдите
// разницу между первым и последним элементом. Для задачи со звездочкой
// использовать заполнение массива целыми числами.

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

int DiffElem(int [] arr)
{
    int res = 0;
    res = arr.Max() - arr.Min();
    return res;
}

// bool Test(int n)
// {
//     return ((arr[i]%2!=0));
// }

int[] arr = Gen1DArr(5, 10, 99);

int result = DiffElem(arr);

Print1DArr(arr);
PrintData("Разница мин макс:", result);