// Задача №49
// Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти
// элементы на их квадраты.
// Например:
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4


// ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
//                                         ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
//                                         ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
//                                         ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
//                                         ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
//                                         ConsoleColor.Yellow};

// int InputNum(string msg)
// {
//     Console.Write(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }


// int[,] Gen2DArr(int row, int col)


// {
//     System.Random numberSyntezator = new System.Random();
//     int i = 0; int j = 0;
//     int[,] arr = new int[row, col];
//     {
//         for (int i = 0; i < row; i++)
//         {
//             for (int j = 0; i < col; j++)
//             {
//                 arr[i, j] = i + j;
//             }
//         }
//         return arr;
//     }
// }

// void PrintTwoDimArray(int[,] arr)
// {
//     int i = 0; int j = 0;
//     while (i < arr.GetLength(0))
//     {
//         j = 0;
//         while (j < arr.GetLength(1))
//         {
//             // Console.ForegroundColor = col[new System.Random().Next(0,16)];
//             Console.Write(arr[i, j] + " ");
//             // Console.ResetColor();
//             j++;
//         }
//         Console.WriteLine();
//         i++;
//     }
// }


// //1) Получение данных от пользователя
// int n = InputNum("Количество строк матрицы");
// int m = InputNum("Количество столбцов матрицы");

// //2) Генерация двумерного массива
// int[,] matrix = Gen2DArr(n, m);

// //3) Печатаем двумерный массив
// PrintTwoDimArray(matrix);

int InputNum(string msg)
{
  Console.Write(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

int[,] Gen2DArr(int xlen, int ylen)
{
  int[,] arr = new int[ylen, xlen];
  for (int i = 0; i < ylen; i++)
  {
    for (int j = 0; j < xlen; j++)
    {
      arr[i, j] = j + i;
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
      Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine("");
  }
}

void Update2DArr(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i = i + 2)
  {
    for (int j = 0; j < arr.GetLength(1); j = j + 2)
    {
      //arr[i, j]*=arr[i, j] ;
      //arr[i, j]=arr[i, j]*arr[i, j];
      arr[i, j] = (int)Math.Pow(arr[i, j], 2);
    }
  }
}


int xlen = InputNum("Ваше число столбцов: ");
int ylen = InputNum("Ваше число строк: ");
int[,] matrix = Gen2DArr(xlen, ylen);
Print2DArr(matrix);
Update2DArr(matrix);
Console.WriteLine();
Print2DArr(matrix);