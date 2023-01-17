// Задача №3
// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.

//Считываем данные с консоли
string? imputLine = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if(imputLine!=null)
{
// ВАРИАНТ 1
//Парсим введенное число
// int nameDay = int.Parse(imputNum);
// //Создаем массив с днями недели
// string[] dayWeek = new string[7];

// dayWeek[0]="понедельник";
// dayWeek[1]="вторник";
// dayWeek[2]="среда";
// dayWeek[3]="четверг";
// dayWeek[4]="пятница";
// dayWeek[5]="суббота";
// dayWeek[6]="воскресенье";
// //Находим название дня недели по введенному номеру и выводим данные в консоль
// Console.WriteLine(dayWeek[nameDay-1]);

//ВАРИАНТ 2

int imputNumber = int.Parse(imputLine);
    string  outDayofWeek = string.Empty;
    switch (imputNumber)
    {
        case 1: outDayofWeek = "понедельник"; break;
        case 2: outDayofWeek = "вторник"; break;
        case 3: outDayofWeek = "среда"; break;
        case 4: outDayofWeek = "четверг"; break;
        case 5: outDayofWeek = "пятница"; break;
        case 6: outDayofWeek = "суббота"; break;
        case 7: outDayofWeek = "воскресенье"; break;
        default: outDayofWeek = "это не день недели!"; break;
    }
    Console.WriteLine(outDayofWeek);
}