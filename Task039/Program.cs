Console.Clear();

Console.Write("Укажите длину массива: ");
int number = int.Parse(Console.ReadLine()!);

int[] OArray = Array1(number);
int[] FArray = Array2(number);

Console.WriteLine($"[{String.Join(", ", OArray)}]");
Console.WriteLine($"[{String.Join(", ", FArray)}]");

int[] Array1 (int N)
{
    int[] result = new int[N];
    for (int i = 0; i < N; i++)
    {
        result[i] = new Random().Next(1, 20);
    }
    return result;
}

int[] Array2 (int N)
{
    int[] result = OArray;
    int i = 0;
    int j = OArray.Length - 1;
    int b = result[i];
    for (; i < OArray.Length / 2; i++)
    {
        b = result[i];
        result[i] = result[j];
        result[j] = b;
        j = j - 1;
    }
    return result;
}