int Num1 = int.Parse(Console.ReadLine() ?? "0");
int Num2 = int.Parse(Console.ReadLine() ?? "0");
int result = Num2 % Num1;
if(result == 0)
{
    Console.WriteLine("Кратно ");
}
else
{
Console.WriteLine("Не кратно " +result);
}