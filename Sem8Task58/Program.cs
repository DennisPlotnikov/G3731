// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

int[,] MultiplicationMatrix(int row, int col, int[,] firstMatrix, int[,] secondMatrix)
{
    var resultMatrix = new int[row,col];

    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < secondMatrix.GetLength(0); k++)
            {
                resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }

    return resultMatrix;
}


int[,] matrix1 = Gen2DArray(2, 2, 0, 9);
int[,] matrix2 = Gen2DArray(2, 2, 0, 9);
Console.WriteLine("Матрица 1");
Print2DArray(matrix1);
Console.WriteLine("Матрица 2");
Print2DArray(matrix2);

Console.WriteLine("Перемножение матриц:");
int[,] newMatrix = MultiplicationMatrix(2, 2, matrix1, matrix2);
Print2DArray(newMatrix);
