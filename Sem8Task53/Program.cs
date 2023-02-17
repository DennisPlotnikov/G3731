// Задача №53
// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю
// строку массива.


int ReadData(string line)

{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}


int[,] Gen2DArr(int row, int col, int min, int max)
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


void Print2DArr(int[,] matr)
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

//1 2 3
//4 5 6
//7 8 9
//int k =0;
//7 8 9
//4 5 6
//1 2 3

void Swap2DArray(int[,] matr)
{
    int k = 0;

    for(int i = 0; i<matr.GetLength(1);i++)
    {
        k=matr[0,i];
        matr[0,i]=matr[matr.GetLength(0)-1,i];
        matr[matr.GetLength(0)-1,i]=k;

    }
}

int m = ReadData("Ваше число строк N: ");
int n = ReadData("Ваше число столбцов M: ");
int[,] matrix = Gen2DArr(m,n,0,100);
Print2DArr(matrix);
Swap2DArray(matrix);
Console.WriteLine("");
Print2DArr(matrix);
