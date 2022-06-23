/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/



int InputInt(string mes)
{
    Console.Write($"Insert {mes}: ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] a)  //печать массива
{
    Console.Write("[");
    for (int i = 0; i < a.Length - 1; i++)
    {
        Console.Write(a[i] + ", ");
    }
    Console.Write(a[a.Length - 1] + "]");
    Console.WriteLine();
}


void FillArrayRandom(int[] a, int min, int max)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(min, max + 1);
    }
}




int sizeArray = InputInt("size array");
int[] threeDigitArray = new int[sizeArray];

FillArrayRandom(threeDigitArray, 100, 999);
PrintArray(threeDigitArray);

int countEven = 0;

for (int i = 0; i < threeDigitArray.Length; i++)
{
    if (threeDigitArray[i] % 2 == 0)
    {
        countEven++;
    }
}

Console.WriteLine(countEven);