// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


int [] RandomArry = new int[10];
Random random = new Random();


for(int i = 0; i < RandomArry.Length; i++)
{
    RandomArry[i] = random.Next();
    Console.WriteLine(RandomArry[i]);
}
Console.WriteLine("-------------------------");
metod(RandomArry,RandomArry.Length);
void metod(int [] newArray, int newNumber)
{
    --newNumber;
    if(newNumber >= 0)
    {
    Console.WriteLine(newArray[newNumber]);
    metod(newArray,newNumber);
    }
}