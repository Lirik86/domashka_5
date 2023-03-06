int[] myArray(int lenght, int min, int max)
{
    Int32[] array = new int[lenght];
    Random rnd = new Random();
    int count = 0;
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
        if(array[i] % 2 == 0)
        {
            count++;
        }
    }
    return array;
}

int counter(Int32[] array)
{
    int count = 0;
    for(int i = 0; i<array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int lenght = 10;
int min = 100;
int max = 1000;
int[] array = myArray(lenght, min, max);
int count = counter(array);
for(int i = 0; i<array.Length; i++)
{
    System.Console.Write(array[i] + " ");
}
System.Console.WriteLine();
System.Console.WriteLine($"Количество четных чисел в массиве размером {lenght} из случайных трехзначных чисел равно {count}");