// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
// (от Голикова А.С.) * Пользователь вводит число нажатий, затем программа следит за нажатиями с клавиатуры и выдает сколько чисел больше 0 было введено.

string ReadData(string msg)

{
    Console.WriteLine(msg);
    return (Console.ReadLine() ?? "0");
}

int CountElem(int[] arr)
{
  int res = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] > 0)
    {
      res++;
    }
  }
  return res;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}


int[] SplitCheck(string numbers)
{
    int[] arr = numbers.Split(" ".ToArray(), StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
    return arr;
}

string numbers = ReadData("Введите числа через пробел: ");

Print1DArr(SplitCheck(numbers));

int count = CountElem(SplitCheck(numbers));

Console.WriteLine(count);