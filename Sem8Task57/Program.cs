// Задача №57
// Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается
// элемент входных данных.


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


void Print1DArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "\t");
    }
}

int[] FillFreqDic(int[,] arr, int len)
{
    int[] farr = new int[len];
    for (int i = 0; i < arr.GetLength(0); i ++)
    {
        for (int j = 0; j < arr.GetLength(1); j ++)
        {
            ++farr[arr[i, j]];
        }
    }
    return farr;
}

int m = ReadData("Ваше число строк N: ");
int n = ReadData("Ваше число столбцов M: ");
// int len = ReadData("Ваша длина словаря: ");
int[,] matrix = Gen2DArr(m, n, 0, 100);
Print2DArr(matrix);

Console.WriteLine("");

int[] freqDic = FillFreqDic(matrix, 101);

Print1DArr(freqDic);