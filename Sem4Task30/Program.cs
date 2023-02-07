// Задача №30
// Напишите программу, которая выводит массив из 8
// элементов, заполненный нулями и единицами в
// случайном порядке.
// Например:
// [1,0,1,1,0,1,0,0]

//Метод читает данные от пользователя
int ReadData(string msg)

{
    Console.Write(msg);
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

void Print1DArr(int[]arr)

{
    Console.Write("[");
    for(int i = 0;i<arr.Length-1;i++)
    {
        Console.Write(arr[i]+",");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}

int arrLen = ReadData("Введите число N (длина массива): ");

int[] arr = Gen1DArr(arrLen, 0, 2);

Print1DArr(arr);