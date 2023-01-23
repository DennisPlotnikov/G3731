Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine()??"0"); //ввод числа
// int res = num/10;
// res=res%10;
// Console.WriteLine(res);

if (num >999 || num<100) //валидация что введено трехзн число
{
    Console.WriteLine("Число не является трёхзначным"); //вывод несогласия
}
else
{
  
char[] digits = num.ToString().ToCharArray();  //число в виде массива развернется
int digit = (int)digits[1]-48; //считали вторую по счету цифру
Console.WriteLine(digit); //вывели цифру
}