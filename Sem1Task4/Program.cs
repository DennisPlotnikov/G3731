// №4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из
// этих чисел.
//  2, 3, 7 -> 7
//  44 5 78 -> 78
//  22 3 9 -> 22


//Считываем данные с консоли 1 число
string? imputNumA = Console.ReadLine();
//Считываем данные с консоли 2 число
string? imputNumB = Console.ReadLine();
//Считываем данные с консоли 3 число
string? imputNumC = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (imputNumA != null && imputNumB != null && imputNumC != null)

{
    //Парсим введенное число
    int numberA = int.Parse(imputNumA);
    //Парсим введенное число
    int numberB = int.Parse(imputNumB);
    //Парсим введенное число
    int numberC = int.Parse(imputNumC);
    //сравниваем числа a и b и c
    if (numberA > numberB)
    {
        if (numberA > numberC)
        {
            Console.WriteLine(numberA); //Выводим данные в консоль
        }
        else
        {
            Console.WriteLine(numberC); //Выводим данные в консоль
        }
    }
    else
    {
        if (numberB > numberC)
        {
            Console.WriteLine(numberB); //Выводим данные в консоль
        }
        else
        {
            Console.WriteLine(numberC); //Выводим данные в консоль
        }
    }
}
