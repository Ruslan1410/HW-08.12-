// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.



Console.WriteLine("Enter number M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number N: ");
int n = int.Parse(Console.ReadLine());

int medot(int m, int n){
    if(m == 0)
    {
        return ++n;
    }
    else if(n == 0)
    {
        return medot(m - 1, 1);
    }
    else
    {
        return medot(m - 1,medot(m,n - 1));
    }


}

int i = medot(m,n);
Console.WriteLine(i);