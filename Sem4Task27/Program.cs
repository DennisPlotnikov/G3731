// №27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в
// числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// * Сделать оценку времени алгоритма через вещественные числа и строки


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

//Метод сложения цифр входящих в число
int SumSym(int num)
{
    int res=0;

while (num>0)
{
    res=res+num%10;
    num=num/10;
}
    return res;
}


//Считываем число пользователя
int num = ReadData("Введите число: ");

//Запускаем метод сложению чисел
int result = SumSym(num);
//Выводим результат
PrintData("Итог: ", result);