// Функция вывода натуральных чисел
static void PrintNaturalNum(int n)
{
    if (n <= 0)
    {
        return;
    }
    Console.Write(n + ", ");
    PrintNaturalNum(n - 1);
}

Console.Clear();
// Ввод числа
Console.Write("Введите число: >> ");
int n = int.Parse(Console.ReadLine()!);

// Вывод
PrintNaturalNum(n);