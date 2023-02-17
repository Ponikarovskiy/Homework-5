// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
Console.Clear();
System.Console.WriteLine();
System.Console.WriteLine("*Задача № 34. Найти чётные числа в массиве*");
System.Console.WriteLine();
System.Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
System.Console.WriteLine("Текущий массив: ");
PrintArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++)
    if (numbers[z] % 2 == 0)
        count++;

System.Console.WriteLine($"Всего чисел - {numbers.Length}");
System.Console.WriteLine($"Из них четных - {count}");

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] numbers)
{
    System.Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + ", ");
    }
    System.Console.WriteLine("]");
    System.Console.WriteLine();
}
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
Console.Clear();
System.Console.WriteLine("*Задача № 36. Найти сумму элементов на нечетных позициях в массиве*");
System.Console.WriteLine();
System.Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
System.Console.WriteLine("Текущий массив: ");
PrintArray(numbers);
int sum = 0;

for (int z = 0; z < numbers.Length; z+=2)
    sum = sum + numbers[z];

    System.Console.WriteLine($"Всего чисел - {numbers.Length}");
    System.Console.WriteLine($"Сумма элементов на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    System.Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            System.Console.Write(numbers[i] + " ");
        }
    System.Console.Write("]");
    System.Console.WriteLine();
}
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
System.Console.WriteLine("*Задача № 38. Найти разницу между максимальным и минимальным элементом массива*");
System.Console.WriteLine();
System.Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
System.Console.WriteLine("Текущий массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
        {
            max = numbers[z];
        }
    if (numbers[z] < min)
        {
            min = numbers[z];
        }
}

System.Console.WriteLine($"Всего чисел - {numbers.Length}");
System.Console.WriteLine($"Максимальный элемент = {max}");
System.Console.WriteLine($"Минимальный элемент = {min}");
System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    System.Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            System.Console.Write(numbers[i] + "; ");
        }
    System.Console.Write("]");
    System.Console.WriteLine();
}