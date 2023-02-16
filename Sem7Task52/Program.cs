// №52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// * Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным
// цветом.


int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[,] Gen2DArr(int xlen, int ylen)
{
    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;
    int[,] arr = new int[ylen, xlen];
    while (i < ylen)
    {
        j = 0;
        while (j < xlen)
        {
            arr[i, j] = numberSyntezator.Next(0, 10);
            j++;
        }
        i++;
    }
    return arr;
}

void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}


string RowAv(int[,] arr)
{
    string averages = "";
    for (int j = 0; j < arr.GetLength(0); j++)

    {
        int Sum = 0;
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            Sum = Sum + arr[i, j];
        }
        double av = Math.Round((double)Sum / arr.GetLength(1), 1);
        averages = averages + av  + "; ";
    }
    return averages;
}


int xlen = InputNum("Ваше число столбцов: ");
int ylen = InputNum("Ваше число строк: ");
int[,] matrix = Gen2DArr(xlen, ylen);
Print2DArr(matrix);
Console.WriteLine();
string result = RowAv(matrix);
Console.WriteLine(result);