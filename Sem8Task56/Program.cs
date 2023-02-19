// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



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


(int x, int y) SearchMinSumElem(int[,] arr)
{
  int buf = 0;
  int row = -1;
  int min = int.MaxValue;
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      buf += arr[i, j];
    }
    if (buf < min)
    {
      min = buf;
      row = i + 1;
    }
    buf = 0;
  }
  return (min, row);
}


// int m = ReadData("Ваше число строк N: ");
// int n = ReadData("Ваше число столбцов M: ");
int[,] matrix = Gen2DArr(2, 3, 0, 9);
Print2DArr(matrix);
(int x, int y) minElem = SearchMinSumElem(matrix);
Console.WriteLine($"Минимальная сумма всех элементов в одной строке {minElem.x}. {minElem.y} строка.");

// "номер строки с наименьшей суммой элементов:", 