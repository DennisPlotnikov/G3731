// №47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};



int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}


double[,] Gen2DArray(int countRow, int countColumn, int minValue, int maxValue)
{
    // System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;
    double[,] outArray = new double[countRow, countColumn];
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = new Random().NextDouble() + new Random().Next(minValue, maxValue + 1);
            j++;
        }
        i++;
    }
    return outArray;
}


void PrintTwoDimArray(double[,] inputArray, int around)
{
    int i = 0; int j = 0;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            // Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            // Console.Write(inputArray[i, j] + " ");
            // Console.ResetColor();
            ColorLine(Math.Round(inputArray[i, j], around));
            Console.Write(" ");
            j++;
        }
        Console.WriteLine();
        i++;
    }
}

// Метод печати цветных чисел
void ColorLine(double num)
{
  string str = num.ToString();
  for (int k = 0; k <= str.Length - 1; k++)
  {
    Console.ForegroundColor = (ConsoleColor)(new System.Random().Next(0, 16));
    Console.Write(str.Substring(k, 1));
    Console.ResetColor();
  }
}


//1) Получение данных от пользователя
int n = InputNum("Количество строк матрицы");
int m = InputNum("Количество столбцов матрицы");
int r = InputNum("Количество знаков после запятой: ");

//2) Генерация двумерного массива
double[,] matrix = Gen2DArray(n, m, -100, 100);

//3) Печатаем двумерный массив
PrintTwoDimArray(matrix, r);