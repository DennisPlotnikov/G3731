// №29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// * Ввести с клавиатуры длину массива и диапазон значений элементов 

//  //Метод читает данные от пользователя
// int ReadData(string msg)

// {
//     Console.Write(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }


// //Метод задает случайный массив
// int[] Gen1DArr(int len, int b, int e)
// {
//     int[] arr = new int[len];

//     Random gen = new Random();

//     for (int i = 0; i < len; i++)
//     {
//         arr[i] = gen.Next(b, e+1);
//     }

//     return arr;
// }
// //Метод печатает массив
// void Print1DArr(int[]arr)

// {
//     Console.Write("[");
//     for(int i = 0;i<arr.Length-1;i++)
//     {
//         Console.Write(arr[i]+",");
//     }
//     Console.WriteLine(arr[arr.Length-1]+"]");
// }

// //Вводим параметры для методов
// int arrLen = ReadData("Введите число N (длина массива): ");
// int b = ReadData("Введите нижний диапазон массива:");
// int e = ReadData("Введите верхний диапазон массива:");

// int[] arr = Gen1DArr(arrLen, b, e);
// //Выводим результат
// Print1DArr(arr);

// *Дополнительно: Написать программу которая из имен через запятую выберет случайное
// имя и выведет в терминал
// Игорь, Антон, Сергей -> Антон
// Подсказка: Для разбора строки использовать метод string.split(). Для выбора
// случайного имени метод Random.Next(1,<длина массива имен>+1). 


string ReadData(string msg)

{
    Console.Write(msg);
    return (Console.ReadLine() ?? "0");
}

//Выводим результат пользователя
// void PrintData(string msg1, string msg2)

// {
//     Console.WriteLine(msg1);
//     Console.WriteLine(msg2);
// }

string names = ReadData("Введите имена: ");

void NameGen(string[] args)
{

    string[] name = names.Split(", ");

    Random rand = new Random();
    int i = rand.Next(0, name.Length);

    Console.WriteLine(name[i]);
    Console.ReadKey();

}
NameGen(args);

