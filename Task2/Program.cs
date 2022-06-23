/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int InputInt(string mes)
{
    Console.Write($"Insert {mes}: ");
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandom(int[] a, int min, int max)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(min, max + 1);
    }
}

void PrintArray(int[] a)  //печать массива
{
    Console.Write("[");
    for (int i = 0; i < a.Length - 1; i++)
    {
        Console.Write(a[i] + ", ");
    }
    Console.Write(a[a.Length-1] + "]");
    Console.WriteLine();
}


int sizeArray = InputInt("size array");
int[] randomArray = new int[sizeArray];

FillArrayRandom(randomArray, -10, 10);

int sumUneven = 0;

for (int i = 1; i < randomArray.Length; i += 2)
{
    sumUneven += randomArray[i];
}

PrintArray(randomArray);
Console.WriteLine(sumUneven);