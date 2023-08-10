// Выводит 3-ю цифру заданного числа или сообщает, что 3-ей цифры нет.

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
Console.WriteLine("-> Выведим третью цифру заданого числа <-");

// Начало алгоритма
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if ( num < 0)
{
    num*= -1;
}

if ( num <= 99)
{
    Console.WriteLine($"Данное число {num} не имеет третьей цифры");
}

// Линейный способ
// if ( num >= 100 && num <= 999 )
// {
//     int a = num % 10;
//     Console.WriteLine($"Третья цифра заданного числа {num}, равна: {a} ");
// }

// if ( num >= 1000 && num <= 9999 )
// {
//     int a = num / 10;
//     int b = a % 10;
//     Console.WriteLine($"Третья цифра заданного числа {num}, равна: {b} ");
// }

// if ( num >= 10000 && num <= 99999)
// {
//     int a = num / 100;
//     int b = a % 10;
//     Console.WriteLine($"Третья цифра заданного числа {num}, равна: {b} ");
// }


//   Метод
if (num >= 100 && num <= 999)
{
    int third = ThirdNum (num);
}
int ThirdNum ( int numb)
{
    int a = num % 10;
    Console.WriteLine($"Третья цифра заданного числа {num}, равна: {a} ");
    return a;
}

if ( num >= 1000 && num <= 9999 )
{
    int third2 = ThirdNum2 (num);
}
int ThirdNum2 ( int numb)
{
    int a = num / 10;
    int b = a % 10;
    Console.WriteLine($"Третья цифра заданного числа {num}, равна: {b} ");
    return b;
}

if ( num >= 10000 && num <= 99999)
{
    int third3 = ThirdNum3 (num);
}
int ThirdNum3 ( int numb)
{
    int a = num / 100;
    int b = a % 10;
    Console.WriteLine($"Третья цифра заданного числа {num}, равна: {b} ");
    return b;
}

//   Scrappy прощается
Console.WriteLine("*Scrappy* завершает свою работу...");
if(name == "Ринат")
{
    Console.WriteLine("Ринат, я буду очень сильно скучать по тебе...");
}
else
{
    Console.WriteLine($"Рад был помочь Вам, {name} ! ^_^");
}