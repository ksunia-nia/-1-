// See https://aka.ms/new-console-template for more information

Console.WriteLine ("Введите число и нажмите Enter");
int N = int.Parse(Console.ReadLine());

int AN = - N;
while ( AN <= N) 
{
    Console.WriteLine(AN); 
    AN++;
}
Console.WriteLine ($"Выше представлен диапазон чисел '- {N} до {N}' выбранного вами числа '{N}'");