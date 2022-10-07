Console.WriteLine("Введите первое число");
string value = Console.ReadLine();

Console.WriteLine("Введите второе число");
string value2 = Console.ReadLine();

int a = int.Parse(value);
int b = int.Parse(value2);

if  (a>b){
            Console.Write(value);
}else{Console.Write(value2);
}
