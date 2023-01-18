// №8 Напишите программу, которая на вход принимает число (N), а на выходе показывает
// все чётные числа от 1 до N.
//  5 -> 2, 4
//  8 -> 2, 4, 6, 8

String? impNum = Console.ReadLine();

if (impNum != null)
{
    int enumber = int.Parse(impNum);
    String result = String.Empty;

    for (int i = 2; i < enumber; i = i + 2)
    {
        result = result + i + ";";
    }
    if (enumber % 2 == 0)
    result = result + enumber;
    Console.WriteLine(result);
}