int[] Result(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max+1);
    }
return array;
}
void PrintV (int[] array)
{
Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {

        if (i < array.Length - 1) Console.Write($"{array[i]}, ");

        else Console.Write(array[i]);

    }
Console.Write("]");
}
int Evennumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0  ) sum = 1 + sum;
    }
return sum;
}
int[] sum22 = Result(4,100,999);
int summa = Evennumbers(sum22);
PrintV(sum22);
Console.WriteLine($"-> {summa}");
