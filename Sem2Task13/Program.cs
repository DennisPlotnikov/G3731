
// char[] digits = Console.ReadLine().ToCharArray();  //число в виде массива развернется
// if (digits.Length > 3) //проверяем что цифра больше чем двузначная
// {
//     Console.WriteLine(digits[2]); //вывели цифру
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет"); //сообщение в консоль
// }

// int num = int.Parse(Console.ReadLine()??"0");

int num = int.Parse(Console.ReadLine() ?? "0");

if (num.ToString().Length>2)
{
int len = num.ToString().Length;

int newnum = (Convert.ToInt32(num/Math.Pow(10, len-3))%10);

Console.WriteLine(newnum);
}
else
{
Console.WriteLine("Третьей цифры нет");
}
