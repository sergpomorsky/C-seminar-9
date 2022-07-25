// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int end = 0;
int rec (int N, int end)
{ 
if(N == end)
{
return end;
}
else
Console.Write(rec(N,end+1)+" ");
return end;
}
rec(N,end);
