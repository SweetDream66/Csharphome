// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// int count = 0;
// FillArrayPositivNumbers(numbers);
// PrintArray(numbers);

// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] % 2 == 0)
//     count++;
// }

// Console.WriteLine($"количество чётных чисел в массиве -> {count} ");

// void FillArrayPositivNumbers(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100,100);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        System.Console.Write($"{item} ");
    System.Console.WriteLine();
}
void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
}
int[] array = new int[12];
FillArray(array);
PrintArray(array);
FillArrayRandomNumbers(array);
int[] sums = FillArrayRandomNumbers(array);
System.Console.WriteLine($"Сумма отрицательных элементов равна {sums[0]}");
System.Console.WriteLine($"Сумма положительных элементов равна {sums[1]}");
