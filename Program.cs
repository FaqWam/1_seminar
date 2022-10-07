
Console.WriteLine("Введите первое число");
string value = Console.ReadLine();

Console.WriteLine("Введите второе число");
string value2 = Console.ReadLine();

Console.WriteLine("Введите третье число");
string value3 = Console.ReadLine();

int a = int.Parse(value);
int b = int.Parse(value2);
int c = int.Parse(value3);

if (a>b && a>c)
{Console.Write(value);}
if (a>b && a<c)
{Console.Write(value3);}
if (a<b && b>c)
{Console.Write(value2);}
if (a<b && b<c)
{Console.Write(value3);}
