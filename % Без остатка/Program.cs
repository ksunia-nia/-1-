// See https://aka.ms/new-console-template for more information

Console.WriteLine ("Введите трехзначное число и нажмите Enter");
int N = int.Parse(Console.ReadLine());
Console.WriteLine ($"Последняя цифра указанного числа {N}");
Console.WriteLine (N % 10);