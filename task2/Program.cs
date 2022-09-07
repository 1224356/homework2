int NumLength(int num)
{
    int i = 1;
    while (num / 10 != 0)
    {
        i++;
        num = num / 10;
    }
    return i;
}

int[] Int2Mas (int num, int NumLen)
{
    int[] result = new int[NumLen];
    while (NumLen > 0)
    {
        result[NumLen-1] = num%10;
        num = num/10;
        NumLen--;
    }
    return result;
}

Console.WriteLine("Введите число");
int numb = Convert.ToInt32(Console.ReadLine());
int numLength = NumLength(numb);
if (numLength < 3)
{
    Console.WriteLine("No");
}
else
{
    int[] a = Int2Mas(numb, NumLength(numb));
    Console.WriteLine(a[2]);
}


