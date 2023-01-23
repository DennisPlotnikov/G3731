int Num1 = int.Parse(Console.ReadLine() ?? "0");
int result1 = Num1 % 7;
int result2 = Num1 % 23;
if((result1 == 0)&&(result2 == 0))
{
    Console.WriteLine("Кратно ");
}
else
{
Console.WriteLine("Не кратно " );
}