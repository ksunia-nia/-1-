// See https://aka.ms/new-console-template for more information

Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine());

int day = num;
Console.WriteLine(day);

if (day < 8)
{
    if (day ==1)
    {
       Console.WriteLine("Понедельник"); 
    }
    else
    {
        if (day ==2)
        {
             Console.WriteLine("вторник");    
        }
        else
        {
            if (day == 3)
            {
                 Console.WriteLine("среда");
            }
            else
            {
                if ( day == 4)
                {
                     Console.WriteLine("четверг");                
                }
                else
                {
                    if (day == 5)
                    {
                         Console.WriteLine("пятница");
                    }
                    else
                    {
                        if (day == 6)
                        {
                             Console.WriteLine("суббота");
                        }
                        else
                        {
                            if (day == 7)
                            {
                                 Console.WriteLine("воскресенье");
                            }                   
                        }
                    }
                }
            }

        }
    }
}
else
{
    Console.WriteLine("Диапазон от 1 до 7, попробуйте еще раз");
}


