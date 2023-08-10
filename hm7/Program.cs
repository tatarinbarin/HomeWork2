// Принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Приветствие Scrappy
Console.WriteLine("Здравствуйте, меня зовут Scrappy");
Console.WriteLine("Вычислительная машина XXI в.");
Console.WriteLine("Я, Ваш *незаменимый помощник*!!!");
Console.WriteLine("Давайте познакомимся c Вами ^_^");
Console.WriteLine("Пожалуйста представьтесь, как Вас зовут???");
string? name = Console.ReadLine();
if(name == "Ринат")
{
    Console.WriteLine("О, это же наш любимый Ринат !!! ");
}
else
{
    Console.WriteLine($"Сердечно привествую Вас, {name} ! ");
}
Console.WriteLine("Давайте проведём одну небольшую операцию...");
Console.WriteLine("-> Обозначим день недели и проверим, является ли этот день выходным <-");


Console.WriteLine("Введите число: (обозначающее день недели)");
int num = Convert.ToInt32(Console.ReadLine());

if ( num < 0 )
{
    num*= -1;
}

if ( num == 0 )
{
    Console.WriteLine ($"Заданное число {num}, не является днём недели.");
    Console.WriteLine ("Подсказка*** -> Введите число от 1 - 7");
}

if ( num > 7)
{
    Console.WriteLine ($"Заданное число {num}, не является днём недели.");
    Console.WriteLine ("Подсказка*** -> Введите число от 1 - 7");
}
//  Алгоритм
if ( num == 1)
{
    Console.WriteLine ($"Заданным числом {num}, является -> Понедельник");
}
if ( num == 2)
{
    Console.WriteLine ($"Заданным числом {num}, является -> Вторник");
}
if ( num == 3)
{
    Console.WriteLine ($"Заданным числом {num}, является -> Среда");
}
if ( num == 4)
{
    Console.WriteLine ($"Заданным числом {num}, является -> Четверг");
}
if ( num == 5)
{
    Console.WriteLine ($"Заданным числом {num}, является -> Пятница");
}
if ( num == 6)
{
    Console.WriteLine ($"Заданным числом {num}, является -> Суббота");
}
if ( num == 7)
{
    Console.WriteLine ($"Заданным числом {num}, является -> Воскресенье");
}

//  Линейный способ
// while ( num >= 1 && num <= 7 )
// {
//     if ( num == 6 || num == 7)
//     {
//         Console.WriteLine ("Данный день, является *выходным*");
//         break;
//     }
//     else
//     {
//         Console.WriteLine ("Данный день, является *рабочим*");
//         break;
//     }
// }


// Метод
while ( num >= 1 && num <= 7 )
{
    bool weekend = WeekendNum (num);
    Console.WriteLine ( weekend ? "Данный день, является *выходным*" : "Данный день, является *рабочим*");
    bool WeekendNum (int num)  
    {
       return num == 6 || num == 7;
    }      
    break;
}

// Scrappy прощается
Console.WriteLine("*Scrappy* завершает свою работу...");
if(name == "Ринат")
{
    Console.WriteLine("Ринат, я буду очень сильно скучать по тебе...");
}
else
{
    Console.WriteLine($"Рад был помочь Вам, {name} ! ^_^");
}