double[] myArray(int lenght, int min, int max)
{
    double[] array = new double[lenght];
    Random rnd = new Random();
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = rnd.Next(min, max) + rnd.NextDouble();
    }
    return array;
}

double minimal(double[] array)
{
    double min1 = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<min1)
        {
            min1 = array[i];
        }
    }
    return min1;
}
double maximal(double[] array)
{
    double max1 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>max1)
        {
            max1 = array[i];
        }
    }
    return max1;
}
int lenght = 10;
int min = 1;
int max = 100;
double[] array = myArray(lenght, min, max);
double maxim = maximal(array);
double minim = minimal(array);
System.Console.WriteLine("В массиве: ");
for (int i = 0; i < array.Length; i++)
{
    System.Console.WriteLine($"{array[i]:F3}");
}
System.Console.WriteLine();
System.Console.WriteLine($"Разница между максимальным элементом массива {maxim:F3} и минимальным {minim:F3} равна {maxim-minim:F3}");