// №25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
// натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// * Написать калькулятор с операциями +, -, /, * и возведение в степень

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

//Метод по нахождению степени числа
int Pow(int a, int b)
{
    int res = 1;

    while (b > 0)
    {
        b = b - 1;
        res = res * a;
    }

    return res;
}

int a = ReadData("Введите число A: ");
int b = ReadData("Введите число B: ");

//Запускаем метод по нахождению числа
int result = Pow(a, b);
//Выводим результат
PrintData("Итог: ", result);