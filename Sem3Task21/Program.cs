// №21 Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// * Сделать метод загрузки точек

//Метод читает данные от пользователя
int ReadData(string msg)

{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод читает строку от пользователя

string ReadDataStr(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine();
}

//Метод получения координат из строки

int[] coord(string str)
{
    int[] res = str.Split(" ".ToCharArray()).Select(x => int.Parse(x)).ToArray();
    return res;
}

//Выводим результат пользователя
void PrintData(string msg, double res)

{
    Console.WriteLine(msg + res);
}

//Вычисляем расстояние между точками в 3D пространстве
double CalcLen(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double res = 0;
    res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return res;
}
//Метод загрузки точек 

string coord12 = ReadDataStr("Введите координтаты точек в формате: x1 y1 z1 x2 y2 z2");
int[] coordXY = coord(coord12);
if (coordXY.Length ==6)
{
    // Вычисляем расстояние
    double len = CalcLen(coordXY[0], coordXY[3], coordXY[1], coordXY[4], coordXY[2], coordXY[5]);



    //Выдаем результат

    PrintData("расстояние между точками:", len);
}
else
{
    Console.WriteLine("Координаты введены некорректно.");
}