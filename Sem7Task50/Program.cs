// №50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру


int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// int[,] Gen2DArr(int xlen, int ylen)
// {
//     int[,] arr = new int[ylen, xlen];
//     for (int i = 0; i < ylen; i++)
//     {
//         for (int j = 0; j < xlen; j++)
//         {
//             arr[i, j] = j + i;
//         }
//     }
//     return arr;
// }

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
            arr[i, j] = numberSyntezator.Next(0, 101);
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

int Find2DArr(int[,] arr, int x, int y)
{
    int result = -1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if ((x - 1 == i) && (y - 1 == j))
            {
                result = arr[i, j];
            }
        }

    }
    return result;
}


int xlen = InputNum("Ваше число столбцов: ");
int ylen = InputNum("Ваше число строк: ");
int x = InputNum("Искомая позиция элемента по вертикали: ");
int y = InputNum("Искомая позиция элемента по горизонтали: ");

int[,] matrix = Gen2DArr(xlen, ylen);
Print2DArr(matrix);
int result = Find2DArr(matrix, x, y);
if (result >= 0)
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Число не найдено.");
}
