// Задача №55
// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае,
// если это невозможно, программа должна вывести
// сообщение для пользователя.

int ReadData(string line)

{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}


int[,] Gen2DArr(int row, int col, int min, int max)
{

    int[,] arr = new int[row, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return arr;
}


void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] TransArray(int[,] arr)
{
    int k = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = i + 1; j < arr.GetLength(1); j++)
        {
            k = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = k;

        }
    }

    return arr;
}

bool TestArr(int[,] arr)
{
    if (arr.GetLength(0) == arr.GetLength(1))
    {
        return true;
    }

    else
    {
        Console.WriteLine("Матрицу перевернуть нельзя!");
        return false;
    }
}




int m = ReadData("Ваше число строк N: ");
int n = ReadData("Ваше число столбцов M: ");
int[,] matrix = Gen2DArr(m, n, 0, 10);
Print2DArr(matrix);
    if(TestArr(matrix))
{
    TransArray(matrix);
    Print2DArr(matrix);
}