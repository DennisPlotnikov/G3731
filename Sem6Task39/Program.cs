// Задача №39
// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на
// первом месте, а первый - на последнем и т.д.)
// Например:
// [1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6]
// Комментарий: эту задачу можно решить 2 способами: 1)
// менять числа местами в исходном массиве; 2) создать
// новый массив и в него записать перевёрнутый исходный
// массив по элементам.


// int ReadData(string msg)

// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

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

void ArrSort(int [] arr)
 
{
// int c;
for (int i = 0; i < (arr.Length / 2); i++) 
{
        (arr[i], arr[arr.Length - 1 - i])=(arr[arr.Length - 1 - i], arr[i]);
    }

}

// int len = ReadData("Введите длину массива: ");
// int b = ReadData("Введите ниж диапазон: ");
// int e = ReadData("Введите верх диапазон: ");
int [] arr = Gen1DArr(5, 10, 99);
Print1DArr(arr);
ArrSort(arr);

Print1DArr(arr);

// int main()
// {
//     int c;
//     int A[8] = { 1, 2, 3, 4, 5, 6, 7, 8 };
//     cout << "1,2,3,4,5,6,7,8";
//     cout << endl;
//     for (int i = 0; i < (8 / 2); i++) {
//         c = A[i];
//         A[i] = A[8 - 1 - i];
//         A[8 - 1 - i] = c;
//     }
//     for (int i = 0; i < 8; i++) {
//         cout << A[i] << " ";
//     }
//     return 0;
// }