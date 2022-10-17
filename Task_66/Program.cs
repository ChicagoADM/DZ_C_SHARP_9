void Exit()
{
    Console.WriteLine();
    Console.Write("Нажмите любою клавишу... ");
    Console.ReadKey();
}
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Cумму натуральных элементов в промежутке от M до N = ");
Zadacha66(n, m);
void Zadacha66(int n, int m, int sum = 0)
{
    sum += m;
    m++;
    if (m > n)
    {
        Console.WriteLine(sum);
        return;    
    }
    Zadacha66(n, m, sum);
}

Exit();
