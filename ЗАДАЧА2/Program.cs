// Найти сумму элементов от M до N, N и M заданы
int SumNumbers(int M, int N)
{
    if(N == M) return N;
    return M + SumNumbers(M + 1, N);
}
Console.Write("Сумма элементов от M до N:");
Console.WriteLine(SumNumbers(1, 8));
