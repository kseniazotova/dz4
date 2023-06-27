// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 452 -> 11
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);
int b = Math.Abs ( Method1(a));
Console.WriteLine($"Cумма цифр в числе {а} = {b}");

int Method1 (int chislo)
{
int sum = 0;
while (chislo != 0)
{
sum += chislo % 10;
chislo /= 10;
}
return sum;
}