// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Введите число элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int count = 0;
Random rnd = new Random();

ReadArray(array);
WriteArray(array);

for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count++;
        }
    }
Console.WriteLine($"Количество чётных чисел в масииве: {count}");

void ReadArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rnd.Next(99, 1000);
    }
}

void WriteArray(int[] numbers)
{
    for(int i = 0; i < (numbers.Length - 1); i++)
    {
        Console.Write($"{numbers[i]}, ");
    }
    Console.WriteLine($"{numbers[numbers.Length - 1]} ");
}