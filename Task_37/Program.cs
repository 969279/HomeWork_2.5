// Семинар 10.11.22 
// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int size = ReadInt("Введтие размер массива: ");
int[] array = new int[size];
Random rnd = new Random();

void ReadArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rnd.Next(0, 10);
    }
}

void WriteArray(int[] numbers)
{
    for(int i = 0; i < (numbers.Length); i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void MultiplyArray(int[] numbers, int[] nums)
{
    for(int i = 0; i < (array.Length / 2); i++)
        {
        nums[i] = array[i] * array[array.Length - 1 - i];
        Console.Write($"{nums[i]} ");
        }
}

ReadArray(array);
WriteArray(array);

if(size %2 == 0)
{
    int n = size / 2;
    int[] nums = new int[n];
    MultiplyArray(array, nums);
} 
else 
{
    int n = size / 2 + 1;
    int[] nums = new int[n];
    MultiplyArray(array, nums);
    Console.WriteLine(nums[array.Length / 2 - 1] = array[array.Length / 2]);
}
