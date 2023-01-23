System.Random numSintezator = new System.Random();

int num = numSintezator.Next(100,1000);
Console.WriteLine(num);

int digitfir = num/100;
int digitlst = num%10;

Console.WriteLine(digitfir*100+digitlst);

