// Показать натуральные числа от M до N, N и M заданы
void PrintNumbers(int M, int N)
{
    if(N < M) return;
    PrintNumbers(M, N - 1);
    Console.Write(N + " ");
}
PrintNumbers(1, 9);
