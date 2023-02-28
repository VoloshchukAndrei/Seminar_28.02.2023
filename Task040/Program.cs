Console.Clear();

// Console.Write("Введите число: ");
// int a = int.Parse(Console.ReadLine()!);

// Console.Write("Введите число: ");
// int b = int.Parse(Console.ReadLine()!);

// Console.Write("Введите число: ");
// int c = int.Parse(Console.ReadLine()!);

Console.Write("Введите стороны треугольника через пробел: ");
string[] ST = Console.ReadLine(). Split(' ');
int a = int.Parse(ST[0]);
int b = int.Parse(ST[1]);
int c = int.Parse(ST[2]);

if (CTriangle (a, b, c))
{
   Console.Write($"Да"); 
}
else
{
   Console.Write($"Нет");
}

bool CTriangle (int a, int b, int c){
    return (((a + b) >= c) && ((a + c) >= b) && ((b + c) >= a));
}