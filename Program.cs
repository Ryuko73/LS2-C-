Console.WriteLine("Введите номер задачи 1,2,3.");
int zd = Convert.ToInt32(Console.ReadLine());
if (zd == 1)
{
    Zadacha1();
}
if (zd == 2)
{
    Zadacha2();
}
if (zd == 3)
{
    Zadacha3();
}

void Zadacha1()
{
int number = new Random().Next(100, 1000);
int a = (number / 10);
int b = (a%10);
Console.WriteLine(number);
Console.WriteLine(b);
}

void Zadacha2()
{
int  number = new Random().Next(100, 100000);
int  result = number;
if (number < 100) Console.WriteLine ("нету");
else
{
string TextNumber = Convert.ToString(number);
if (TextNumber.Length > 2)
    Console.WriteLine(number);
    Console.WriteLine(TextNumber[2]);
}

}

void Zadacha3()
{
Console.WriteLine("Введите день недели");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 6 || day == 7)
{
    Console.WriteLine("Ура,выходной");
}
else if (day < 6)
{
  Console.WriteLine("Не выходной");
}
}
