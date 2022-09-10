double[] getCubes(int elems)
{
    double[] Cubes = new double[elems];
    for (int i = 0; i < Cubes.Length; i++)
    {
        Cubes[i] = Math.Pow(i + 1, 3);
    }
    return Cubes;
}

void printCubes(double[] MasCubes)
{
    for (int elem = 0; elem < MasCubes.Length; elem++)
    {
        if (elem + 1 == MasCubes.Length)
        {
            Console.Write(MasCubes[elem]);
        }
        else
        {
            Console.Write(MasCubes[elem] + ", ");
        }
        
    }
}

Console.WriteLine("Введите число:");
printCubes(getCubes(Convert.ToInt32(Console.ReadLine())));

