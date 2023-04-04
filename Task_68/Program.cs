// Вычисление функции Аккермана
static int Ackerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Ackerman(m - 1, 1);
    }
    else
    {
        return Ackerman(m - 1, Ackerman(m, n - 1));
    }
}

// Ввод данных
Console.Clear();
Console.Write("Введите M:>> ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите N:>> ");
int n = int.Parse(Console.ReadLine()!);

// Вычисление и вывод
int result = Ackerman(m, n);
Console.WriteLine("Значение функции Аккермана для m={0} и n={1} равно {2}", m, n, result);