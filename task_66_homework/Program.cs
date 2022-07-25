// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
int rec (int N, int M)
{ if(N < M)
{
    return N + rec(N + 1, M);
}
if (N > M)
{
    return N + rec(N - 1, M);
}
else 
return M;
}
Console.WriteLine($"Сумма чисел от M до N равна {rec(N,M)}");