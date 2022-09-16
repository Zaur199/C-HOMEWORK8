// Найти сумму цифр числа
int SumONeNumber(int number)
{
    if(number < 1) return 0;
    return SumONeNumber(number / 10) + number % 10;
}
Console.Write("Input number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Сумма цифр в числе равна: ");
Console.WriteLine(SumONeNumber(number));

