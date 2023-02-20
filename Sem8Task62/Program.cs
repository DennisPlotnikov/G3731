// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



// int ReadData(string line)

// {
//     Console.WriteLine(line);
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     return number;
// }


int[,] Gen2DArray(int n)
{

    int[,] matr = new int[n, n];
    int i = 0, j = 0;

    int count = 1;

    while (n != 0)
    {
        int k = 0;
        do { matr[i, j++] = count++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) matr[i++, j] = count++;
        for (k = 0; k < n - 1; k++) matr[i, j--] = count++;
        for (k = 0; k < n - 1; k++) matr[i--, j] = count++;

        ++i; ++j; n = n < 2 ? 0 : n - 2;
    }
    return matr;
}












// }
// for (int i = 0; i < matr.GetLength(0); i++)
// {
//     count = count + 1;
//     matr[i, j] = count;
// }







void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write("{0,3} ", matr[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


// int[,] Spiral(int[,] matr)
// {
//     int minElem = int.MaxValue;
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (minElem > matr[i, j])
//             {
//                 raw = i;
//                 col = j;
//                 minElem = matr[i, j];
//             }
//         }
//     }
//     return (raw, col);
// }



int[,] matrix = Gen2DArray(10);
Print2DArray(matrix);

// (int x, int y) minElem = SearchMinElem(matrix);

// int[,] newMatrix = Update2DArray(matrix, minElem.x, minElem.y);
// Print2DArray(newMatrix);

