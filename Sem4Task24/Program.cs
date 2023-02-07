// Задача №24
// Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А.
// Например:
// 7 -> 28
// 4 -> 10
// 8 -> 36

//Метод читает данные от пользователя
int ReadData(string msg)

{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Выводим результат пользователя
void PrintData(string msg1, int msg2)

{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

int SumSimple(int numA)
{
    int SumOfNum = 1;

    for (int i = 2; i <= numA; i++)
    {
        SumOfNum+=i;
    }

        return SumOfNum;
}

int SumGauss(int numA)
{
    return (numA*(numA+1))/2;
}

int numberA = ReadData("Введите число A");

int res1 = SumSimple(numberA);
int res2 = SumGauss(numberA);

PrintData("Сумма чисел от 1 до A (Simple): ", res1 );
PrintData("Сумма чисел от 1 до A (Gauss): ", res1 );