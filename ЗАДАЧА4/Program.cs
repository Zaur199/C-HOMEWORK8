// Написать программу вычисления функции Аккермана
int Aсkerman(int m, int n)
{
    if(m == 0) return (n + 1);
    else if(n == 0) return Aсkerman(m - 1, 1);
    else return Aсkerman(m - 1, Aсkerman(m, n - 1));
}
Console.WriteLine("Input m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Input n: ");
int n = int.Parse(Console.ReadLine());
Console.Write($"Значение функции Aсkerman({m}, {n}) равно: ");
Console.WriteLine(Aсkerman(m, n));