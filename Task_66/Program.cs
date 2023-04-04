// Функция нахождения суммы элементов от М до N
static int Result(int m, int n)
{
    int sum = 0;
    for (int i = m; i <= n; i++)
    {
        sum += i;
    }
    return sum;
}

// Ввод значений
Console.Clear();
Console.Write("Введите M:>> ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите N:>> ");
int n = int.Parse(Console.ReadLine()!);

// Вычисление и вывод
int sum = Result(m, n);
Console.WriteLine();
Console.WriteLine("Сумма натуральных чисел в промежутке от {0} до {1} равна {2}", m, n, sum);