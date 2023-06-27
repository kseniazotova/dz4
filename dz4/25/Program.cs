 // Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 3, 5 -> 243 (3⁵)
Console.WriteLine("Введите два числа");
int a = int.Parse(Console. ReadLine ()!);
int b = int.Parse(Console. ReadLine ()!);
int s = Stepen (a, b);
Console.WriteLine (s) ;
int Stepen (int chislo, int stepe)
{
int i = 1;
int step = 1;
while (i <= stepe)
{
step *= chislo;
i=i+1;
}
return step; 
}