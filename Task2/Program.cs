// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int SumNums(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

int pos = InputNum("Введите количество элементов массива: ");
int minValue = InputNum("Введите значение минимального элемента массива: ");
int maxValue = InputNum("Введите значение максимального элемента массива: ");

int[] myArray = CreateArray(pos);
FillArray(myArray, minValue, maxValue);
PrintArray(myArray);

int sumnumbers = SumNums(myArray);
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях равна {sumnumbers}");
