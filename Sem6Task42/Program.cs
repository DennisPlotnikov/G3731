// Задача №42
// Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.
// Например:
// 45 -> 101101
// 3 -> 11
// 2 -> 10



int ReadData(string msg)

{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

string Binary(int num)
{
    string result = string.Empty;
    while (num > 0)
    {

        result = Convert.ToString(num % 2) + result;
        num = num / 2;


    }
    return result;
}

string result = Binary(ReadData("Введите число: "));
Console.WriteLine(result);