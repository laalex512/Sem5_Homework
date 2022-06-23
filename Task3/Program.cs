/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/


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

int ArrayMaxCount(int[] a)
{
    int min=a[0];
    for (int i = 1; i < a.Length; i++)
    {
        if(a[i]>min)
            min = a[i];
    }
    return min;
}

int ArrayMinCount(int[] a)
{
    int min=a[0];
    for (int i = 1; i < a.Length; i++)
    {
        if(a[i]<min)
            min = a[i];
    }
    return min;
}

void PrintArray(int[] a)  
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

FillArrayRandom(randomArray, -1000, 1000);
PrintArray(randomArray);

int result = ArrayMaxCount(randomArray)-ArrayMinCount(randomArray);

Console.WriteLine(ArrayMaxCount(randomArray));
Console.WriteLine(ArrayMinCount(randomArray));
Console.WriteLine(result);
