// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double[] CraeteArray(int size)
{
    return new double[size];
}

void FillArray(double[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * 100), 2);
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double MaxNum(double[] array)
{
    int posMax = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > array[posMax])
            array[posMax] = array[i]; 
    }
    return array[posMax];
}

double MinNum(double[] array)
{
    int posMin = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[posMin])
            array[posMin] = array[i]; 
    }
    return array[posMin];
}

int pos = InputNum("Введите размер массива: ");
double[] myArray = CraeteArray(pos);
FillArray(myArray);
PrintArray(myArray);

double maxValue = MaxNum(myArray);
Console.WriteLine($"max {maxValue}");
double minValue = MinNum(myArray);
Console.WriteLine($"min {minValue}");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {maxValue - minValue}");
