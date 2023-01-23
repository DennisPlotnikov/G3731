Console.WriteLine("Input for nums: ");
int Num1 = int.Parse(Console.ReadLine() ?? "0");
int Num2 = int.Parse(Console.ReadLine() ?? "0");

// if (Num1 * Num1 == Num2)
// {
//     Console.WriteLine("Второе число квадрат первого");
// }
// ifelse(Num2 * Num2 == Num1)
// {
//     Console.WriteLine("Первое число квадрат второго");
// }
// else
// {
//     Console.WriteLine("Не квадрат");
// }
TestSQRT(Num1,Num2);
TestSQRT(Num2,Num1);

void TestSQRT(int i, int j)
{
    if ((int)Math.Pow(i, 2) == j)
    {
        Console.WriteLine("да, число " + j + " является квадратом числа " + i);
    }
    else
    {
        Console.WriteLine("число " + j + " не является квадратом числа " + i);
    }
}