// **Задача 42:**Напишите программу,
//  которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101

// 3 -> 11

// 2 -> 10


// Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

// string result = DecToNum(number, 2);

Console.WriteLine($"{number} -> {ZeroOne (number)}");

// Console.WriteLine($"[{String.Join(",", ZeroOne (number))}]");

string ZeroOne (int number)
{
    string result = "";
    while (number > 0)
    {
        result = (number % 2) + result;
        number /= 2;
    }
       return result;
}

// string DecToNum(int decNumber, int otherSystem)
// {
//     string result = "";
//     string numbers = "0123456789ABCDEF";
//     while (decNumber > 0)
//     {
//         result = numbers[decNumber % otherSystem] + result;
//         decNumber /= otherSystem;
//     }
//     return result;
// }