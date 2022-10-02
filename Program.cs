void second_number ()
{
    Console.WriteLine("Введите трёх значное число");
    string number = Console.ReadLine();
    Console.Write(number[1]);
}

void third_number()
{
    Console.WriteLine("Введите любое число");
    string number = Console.ReadLine();
    int int_number = int.Parse(number);
    if ((int_number/100) < 1)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
    Console.Write(number[2]);
    }
}

void weekend()
{
    Console.WriteLine("Введите номер дня недели");
    int number = int.Parse(Console.ReadLine());
    if ((number >= 6) && (number < 8))
    {
        Console.WriteLine("Да");
    }
    else if (number > 7)
    {
        Console.WriteLine("Такого дня недели нет, их всего 7! Попробуй заново.");
    }
    else
    {
        Console.WriteLine("Нет");
    }

}


Console.WriteLine("У вас есть уникальная возможность узнаст:");
Console.WriteLine("1 - Вторую цифру трёхзначного числа");
Console.WriteLine("2 - Третью цифру числа");
Console.WriteLine("3 - Является ли день недели выходным днём");
Console.WriteLine("Выбри то, что хочешь узнать: 1, 2, 3?");


int Choice_number = int.Parse(Console.ReadLine());

if (Choice_number == 1)
{
    second_number();
}
else if (Choice_number == 2)
{
    third_number();
}
else if (Choice_number == 3)
{
    weekend();
}
else
{
    Console.WriteLine("Такого варианта нет. Попробуй снова.");
}