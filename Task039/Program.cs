//Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)

Console.Clear();

Console.Write("Укажите длину массива: ");
int number = int.Parse(Console.ReadLine()!);

int[] array = FirstArray(number);
Console.WriteLine(String.Join(", ", array));

// int[] reversArray = reversArrayTwo(array);
// Console.WriteLine(String.Join(", ", reversArray));

reversArrayOne(array);
Console.WriteLine(String.Join(", ", array));

int[] FirstArray (int N)
{
    int[] result = new int[N];
    for (int i = 0; i < N; i++)
    {
        result[i] = new Random().Next(1, 20);
    }
    return result;
}

void reversArrayOne (int[] N)
{
    int j = N.Length - 1;
    for (int i = 0; i < N.Length / 2; i++)
    {
        int b = N[i];
        N[i] = N[j];
        N[j] = b;
        j = j - 1;
    }
}

// int[] reversArrayTwo (int[] N)
// {
//     int[] result = new int[N.Length];
//     int j = number - 1;
//     for (int i = 0; i < N.Length; i++)
//     {
//         result[i] = N[N.Length - 1 - i];
//     }
//     return result;
// }