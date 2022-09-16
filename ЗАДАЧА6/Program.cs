// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем
int PrintNumbers(int x, int y, int number)
{
    if(number == 1) return x;
    if(number == 2) return y;
    return PrintNumbers(x, y, number - 1) + PrintNumbers(x, y, number - 2);
}

int N = 9;
int A = 3;
int B = 5;

for (int i = 1; i < N; i++)
{
    Console.Write(PrintNumbers(A, B, i) + " ");
}