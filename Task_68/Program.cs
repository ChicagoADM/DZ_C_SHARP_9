void Exit()
{
    Console.WriteLine();
    Console.Write("Нажмите любою клавишу... ");
    Console.ReadKey();
}
//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n

Console.Write("Введите неотрицательное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
A(n, m);
Print(m,n);
int A(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return A(m - 1, 1);
    if (m > 0 && n > 0) return A(m - 1, A(m, n - 1));
    return A(m, n);
}
void Print(int m, int n)
{
    Console.WriteLine();
    Console.WriteLine($" A({m},{n}) = {A(m, n)}");
}

Exit();