string[] week = {"Нет", "Нет", "Нет", "Нет", "Нет", "Да", "Да"};
Console.WriteLine("Введите цифру, обозначающую день недели");
int day = Convert.ToInt32(Console.ReadLine());
while (day<1 ^ day>7)
{
    Console.WriteLine("Не верно введена цифра, обозначающая день недели. Необходимо ввести цифру от 1 до 7");
    day = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(week[day-1]);

