// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] Gen3DArray(int x, int y, int z, int min, int max)
{

    int[,,] matr = new int[x, y, z];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1); k++)
            {
                matr[i, j, k] = new Random().Next(min, max + 1);
            }
        }

    }
    return matr;
}


void Print3DArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(0); k++)
            {
                {
                    Console.Write($"{matr[i, j, k]}{(i,j,k)} ");
                }
                
            }
            Console.WriteLine();
        }
      
    }
}

int[,,] matrix = Gen3DArray(2, 2, 2, 0, 99);
Print3DArray(matrix);

