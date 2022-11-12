//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int size = ReadInt("Введтие размер массива: ");
int[] array = new int[size];
int sum = 0;

Random rnd = new Random();

ArrayRandomNumbers(array);
WriteArray(array);

for (int i = 1; i < array.Length;)
{
    sum = sum + array[i];
    i += 2;
}
Console.WriteLine($"Сумма нечётных эллементов: {sum}");

void ArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-99, 99);
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

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

