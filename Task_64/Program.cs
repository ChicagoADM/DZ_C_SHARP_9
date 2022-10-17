void Exit()
{
    Console.WriteLine();
    Console.Write("Нажмите любою клавишу... ");
    Console.ReadKey();
}
//Задача 64: Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Натуральные числа кратные 3-ём: ");
Zadacha64(n,m);
void Zadacha64(int n, int m)
{
    {
        m++;
        if (m % 3 == 0)
            Console.Write(m + " ");
        if (m >= n)
            return;
    }
    Zadacha64(n,m);
}

Exit();