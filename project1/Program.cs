// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.


void Num(int m, int n)
{
    Console.WriteLine(m);
    if(m < n){
        Num(++m,n);
    }
}

Console.WriteLine("Enter number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number N: ");
int n = Convert.ToInt32(Console.ReadLine());

Num(m,n);
