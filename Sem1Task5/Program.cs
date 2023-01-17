// Задача №5
// Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// Например:
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

string? imputNumber = Console.ReadLine();

if(imputNumber!=null)
{
int number = int.Parse(imputNumber);

int negnumber = number*-1;

string array = String.Empty;

while(negnumber < number)
{ 
    array = array + negnumber +",";
    negnumber = negnumber + 1;
}
array = array + number;
Console.WriteLine(array);
}