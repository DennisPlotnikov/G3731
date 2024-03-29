﻿// Задача №59
// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и
// столбец, на пересечении которых расположен
// наименьший элемент массива.


int ReadData(string line)

{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}


int[,] Gen2DArray(int row, int col, int min, int max)
{

    int[,] matr = new int[row, col];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matr;
}


void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Update2DArray(int[,] matr, int x, int y)
{
    int[,] resArr = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];

    int k = 0;
    int m = 0;

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        m = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i != x && j != y)
            {
                resArr[k, m] = matr[i, j];
            }
            if (j != y)
            {
                m++;
            }
        }
        if (i != x)
        {
            k++;
        }
    }
    return resArr;
}

(int x, int y) SearchMinElem(int[,] matr)
{
    int raw = 0;
    int col = 0;
    int minElem = int.MaxValue;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (minElem > matr[i, j])
            {
                raw = i;
                col = j;
                minElem = matr[i, j];
            }
        }
    }
    return (raw, col);
}



int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matrix = Gen2DArray(m, n, 0, 100);
Print2DArray(matrix);

(int x, int y) minElem = SearchMinElem(matrix);

int[,] newMatrix = Update2DArray(matrix, minElem.x, minElem.y);
Print2DArray(newMatrix);







