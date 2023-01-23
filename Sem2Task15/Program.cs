// int day = int.Parse(Console.ReadLine() ?? "0");

// if (day > 7 || day < 1)
// {
//     Console.WriteLine("Не день недели");
// }
// else
// if (day > 5)
// {
//     Console.WriteLine("Выходной");
// }
// else 
// {
//     Console.WriteLine("Рабочий");
// }


int num = int.Parse(Console.ReadLine() ?? "0");

var dict = new Dictionary<int, string>()
{
    { 1, "Рабочий"},
    { 2, "Рабочий"},
    { 3, "Рабочий"},
    { 4, "Рабочий"},
    { 5, "Рабочий"},
    { 6, "Выходной"},
    { 7, "Выходной"}
};

bool keyExists = dict.ContainsKey(num);
if (keyExists)
{
    Console.WriteLine(dict[num]);
}
else
{
    Console.WriteLine("{0} does not exist in dict", num);
}
