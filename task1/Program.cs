int[] Int2Mas (int num)
{
    int i = 3;
    int[] result = new int[i];
    while (i > 0)
    {
        result[i-1] = num % 10;
        num = num / 10;
        i--;
    }
    return result;
}

Console.WriteLine("Введите трехзначное число:");
int[] mas = Int2Mas(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine(mas[1]);

