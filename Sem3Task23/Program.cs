// №23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов
// чисел от 1 до N.1
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// * Вывести таблицу с границами и значениями друг над другом


//Метод читает данные от пользователя
int ReadData(string msg)

{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Выводим результат пользователя
void PrintData(string msg1, string msg2)

{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

//Вывод нахождения степени чисел от 1 до N
string LineBuilder(int n, int p)
{
    string s = "";
    for (int i=1;i<=n;i++)
    {
        s+=Math.Pow(i,p).ToString()+"\t";
    }
    return s;
}

//Ввод данных

int num = ReadData("Введите N: ");

//Собираем первую строку таблицы    
string line1 = LineBuilder(num,1);
//Собираем вторую строку таблицы 
string line2 = LineBuilder(num,3);


//Вывод данных
PrintData(line1, line2);