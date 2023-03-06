int[] myArray(int lenght, int min, int max)
{
    Int32[] array = new int[lenght];
    Random rnd = new Random();
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

int summa(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int lenght = 10;
int min = 1;
int max = 10;
int[] array = myArray(lenght, min, max);
int sum = summa(array);
for (int i = 0; i < array.Length; i++)
{
    System.Console.Write(array[i] + " ");
}
System.Console.WriteLine();
System.Console.WriteLine($"Сумма элементов массива индекс, которых нечетен равен {sum}");