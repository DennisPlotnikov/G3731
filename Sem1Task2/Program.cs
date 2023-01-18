// №2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число
// большее, а какое меньшее.
//  a = 5; b = 7 -> max = 7
//  a = 2 b = 10 -> max = 10
//  a = -9 b = -3 -> max = -3

//Считываем данные с консоли 1 число
string? imputNum1 = Console.ReadLine();
//Считываем данные с консоли 2 число
string? imputNum2 = Console.ReadLine();
//Проверяем, чтобы данные были не пустыми
if (imputNum1 != null && imputNum2 != null)

{
    //Парсим введенное число
    int number1 = int.Parse(imputNum1);
    //Парсим введенное число
    int number2 = int.Parse(imputNum2);
    //сравниваем числа a и b
    if (number1 > number2)
    {
        Console.WriteLine("Число 1 больше 2"); //Выводим данные в консоль
    }
    else
    {
        Console.WriteLine("Число 2 больше 1"); //Выводим данные в консоль
    }
}