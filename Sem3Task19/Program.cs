// №19 Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
// * Сделать вариант через СЛОВАРЬ четырехзначных палиндромов



// Метод теста пятизначного палиндрома в цифре

bool PalindromTest(int n)
{
    bool res = false;
    int d1 = n / 10000;
    int d2 = (n / 1000) % 10;
    int d3 = (n / 10) % 10;
    int d4 = n % 10;
    res = ((d1 == d4) && (d2 == d3)) ? true : false;
    return res;
}

//Метод читает данные от пользователя

int ReadData(string msg)

{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод печати результата пользователя

void PrintData(bool res)

{
    if (res == true)
    {
        Console.WriteLine("Это палиндром!");
    }
    else
    {
        Console.WriteLine("Это не палиндром!");
    }
}


//Вводим параметры для методов

// int number = ReadData("Введите пятизначное число: ");

//Проверяем что число пятизначное
// int len = Convert.ToString(number).Length;
// if (len == 5)
// {
//     PrintData(PalindromTest(number)); //Выводим данные 
// }
// else
// {
//     Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
// }

//Метод через справочник

// Метод заполнения словаря
// Создаём новый словарь и очищаем
var Palin5Digit = new Dictionary<int, string>();
Palin5Digit.Clear();
// Заполняем словарь
for (int i = 10000; i < 100000; i++)
{
    if (PalindromTest(i) == true) { Palin5Digit.Add(i, "Это палиндром!"); }
}
// Заполнение словаря и проверка заполнения словаря
// foreach (var dig in Palin5Digit)
// {
//   Console.WriteLine($"key: {dig.Key}  value: {dig.Value}");
// }
// Console.WriteLine($"В словаре {Palin5Digit.Count} значений пятизначных палиндромов.");
// Запрос пользователю и вывод результата
int number = ReadData("Введите пятизначное число: ");
if (number > 9999 && number < 100000)
{
  PrintData(Palin5Digit.ContainsKey(number));
}
else
{
  Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
}