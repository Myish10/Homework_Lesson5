// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
}


void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();

}

int Number(int[] array)
{
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            index++;
    }
    return index;
}

int pos = InputNum("Введите количество элементов массива: ");
int minValue = InputNum("Введите значение минимального элемента массива: ");
int maxValue = InputNum("Введите значение максимального элемента массива: ");

int[] myArray = CreateArray(pos);
FillArray(myArray, minValue, maxValue);
PrintArray(myArray);
int number = Number(myArray);
Console.WriteLine($"Количество четных чисел в массиве равно {number}");

