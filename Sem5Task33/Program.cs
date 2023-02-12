// Задача №33
// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в
// массиве.
// Например:
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


int ReadData(string msg)

{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

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

void PrintData(string msg1, string msg2)

{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

int Search(int[] arr, int e)
{
    int res = -1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == e)
        {
            res = i; break;
        }
    }
    return res;
}

int e = ReadData("Введите искомое число массива: ");

int[] arr = Gen1DArr(3, 0, 9);

int result = Search(arr, e);

string answer = (result > -1) ? "-> есть" : "-> нет";
Print1DArr(arr);
PrintData(e + $"; в массиве", answer);