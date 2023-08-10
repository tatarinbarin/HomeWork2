// Принимает на вход 3-х значное число, а на выходе показывает 2-ую цифру этого числа.

// Приветствие Scrappy
Console.WriteLine("Здравствуйте, меня зовут Scrappy");
Console.WriteLine("Вычислительная машина XXI в.");
Console.WriteLine("Я, Ваш *незаменимый помощник*!!!");
Console.WriteLine("Давайте познакомимся c Вами ^_^");
Console.WriteLine("Пожалуйста представьтесь, как Вас зовут???");
string name = Console.ReadLine();
if(name == "Ринат")
{
    Console.WriteLine("О, это же наш любимый Ринат !!! ");
}
else
{
    Console.WriteLine($"Сердечно привествую Вас, {name} ! ");
}
Console.WriteLine("Давайте проведём одну небольшую операцию...");
Console.WriteLine("-> Выведим вторую цифру данного числа <-");

// Начало алгоритма
Console.WriteLine("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if ( num < 0 )
{
    num*= -1;
}

//    "Линейный способ"
// if ( num >= 100 && num <= 999)
// {
//     int a = num / 10;
//     int b = a % 10;
//     Console.WriteLine($"Вторая цифра данного числа {num}, является -> {b}");
// }
// else
// {
//     Console.WriteLine ($" *Техническая ошибка !!!* Данное число {num} , является некорректным. ");
//     Console.WriteLine (" *Подсказка* Введите трёхзначное число...");
// }


//    "Метод"
if ( num >= 100 && num <= 999)
{
    int enter = EnterNum (num);
}
else
{
    Console.WriteLine ($" *Техническая ошибка !!!* Данное число {num} , является некорректным. ");
    Console.WriteLine (" *Подсказка* Введите трёхзначное число...");
}

    int EnterNum (int numb)
{
    int a = num / 10;
    int b = a % 10;
    Console.WriteLine($"Вторая цифра данного числа {num}, является -> {b}");
    return b;
}

//  Scrappy прощается
Console.WriteLine("*Scrappy* завершает свою работу...");
if(name == "Ринат")
{
    Console.WriteLine("Ринат, я буду очень сильно скучать по тебе...");
}
else
{
    Console.WriteLine($"Рад был помочь Вам, {name} ! ^_^");
}