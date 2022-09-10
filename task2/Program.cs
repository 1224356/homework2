int[] getPointCoors(string PointName)
{
    int[] result = new int[3];
    for (int i = 0; i  < 3; i++)
    {
        string[] CoorNames = {"X", "Y", "Z"};
        Console.WriteLine($"Введите координату {CoorNames[i]} точки {PointName}:");
        result[i] = Convert.ToInt32(Console.ReadLine());
    }
    return result;
}

double Distance(double xA, double xB, double yA, double yB, double zA, double zB)
{
    return Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));
}

int[] PointA = getPointCoors("A");
int[] PointB = getPointCoors("B");  
Console.WriteLine(Math.Round(Distance(PointA[0], PointB[0], PointA[1], PointB[1], PointA[2], PointB[2]), 2));
