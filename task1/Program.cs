int[] Int2Mas (int num)
{
    int i = 5;
    int[] pal = new int[i];
    while (i > 0)
    {
        pal[i-1] = num % 10;
        num = num / 10;
        i--;
    }
    return pal;
}

string checkPal (int[] mpal)
{
    string result = String.Empty;
    if (mpal[0] == mpal[4] && mpal[1] == mpal[3])
    {
        result = "да";
    }
    else
    {
        result = "нет";
    }
    return result;
}

Console.WriteLine("Введите пятизначное число");
Console.WriteLine(checkPal(Int2Mas(Convert.ToInt32(Console.ReadLine()))));