// Написать программу возведения числа А в целую степень B
Console.Write("Input numberA: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Input numberB: ");
int numberB = int.Parse(Console.ReadLine());
int DegreeOfNumber(int numberA, int numberB)
{
    if(numberB < 1) return 1; // Или if(numberB == 1) return numberA;
    else return numberA * (DegreeOfNumber(numberA, numberB - 1));
}
Console.Write($"Число {numberA} в степени {numberB} равно: ");
Console.WriteLine(DegreeOfNumber(numberA, numberB));