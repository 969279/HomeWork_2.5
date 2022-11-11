// Семинар 10.11.22 
// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int size = ReadInt("Введтие размер массива: ");
int[] array = new int[size];

Random rnd = new Random();

void ReadArray(int[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
        number[i] = rnd.Next(0, 10);
    }
}

void WriteArray(int[] number)
{
    for(int i = 0; i < (number.Length); i++)
    {
        Console.Write($"{number[i]} ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void MultiplyArray(int[] number, int[] composition)
{
    for(int i = 0; i < (number.Length / 2); i++)
        {
        composition[i] = number[i] * number[number.Length - 1 - i];
        Console.Write($"{composition[i]} ");
        }
}

ReadArray(array);
WriteArray(array);

if(size %2 == 0)
{
    int num = size / 2;
    int[] numbers = new int[num];
    MultiplyArray(array, numbers);
} 
else 
{
    int num = size / 2 + 1;
    int[] numbers = new int[num];
    MultiplyArray(array, numbers);
    Console.WriteLine(numbers[array.Length / 2 - 1] = array[array.Length / 2]);
}
