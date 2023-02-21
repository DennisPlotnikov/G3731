// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintResult(long prefix)
{
    Console.WriteLine(prefix);
}

// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))


long Ack(long a, long b)
{
    if (a == 0) return b + 1;
    if (b == 0) return Ack(a - 1, 1);
    else
        return Ack(a - 1, Ack(a, b - 1));
}


// long MyPow(int a, int b)
// {
//     if(b==2)return a*a;
//     return MyPow(a,b/2)*MyPow(a,b/2);
// }

int numberA = ReadData("Enter number A:");
int numberB = ReadData("Enter number B:");

// long res1 =0;
// long res2 =0;

// DateTime d1 = DateTime.Now;
long res1 = Ack(numberA, numberB);
// PrintResult("Решение Ack" + (DateTime.Now - d1));
// ConsoleWriteLine();
PrintResult(res1);
// DateTime d2 = DateTime.Now;
// res2 = MyPow(numberA,numberB);
// PrintResult("Решение MyPow" + (DateTime.Now - d2));