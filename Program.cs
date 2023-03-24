// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int [] startArray =GetArray(6,100,999);
Console.WriteLine(String.Join (" ", startArray));
Console.WriteLine($" количество четных элементов в массиве={GetEvenCount(startArray )}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res =new int [size];
    for ( int i =0; i <size; i ++)
    {
        res[i]= new Random().Next(minValue, maxValue+1);

    }
    return res;
}

int GetEvenCount(int[] array)
{
    int count =0;
    foreach (var item in array)
    {
        if (item %2 ==0) count++;
    }
    return count;
}


//2: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных индексах

int[] GetArray(int size)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
            {
                array[i] = new Random().Next(0, 1000);
            }
        return array;
    }
Console.Write("Введите длину массива: ");
int a = int.Parse(Console.ReadLine()!);
int[] array = GetArray(a);
Console.WriteLine($"[{String.Join(", ", array)}]");
int sum = 0;
for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
Console.WriteLine($"Сумма чисел, стоящих под нечетными индексами, равна {sum}");

//Задача 3: Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//Результат запишите в новом массиве.

int[] GetArray(int size)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
            {
                array[i] = new Random().Next(1, 10);
            }
        return array;
    }
Console.Write($"Введите количество элементов в массиве: ");
int s = int.Parse(Console.ReadLine()!);
int[] array = GetArray(s);
Console.WriteLine($"[{String.Join(", ", array)}]");

int n = array.Length;
int m = array.Length / 2;

for (int i = 0; i < m; i++)
{
    int sum = 0;
    sum = array[i] * array[n - i - 1];
    int[] res = new int[] {sum};
    Console.Write($"[{String.Join(", ", res)}]");
}