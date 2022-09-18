// 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да

Console.Write("Введите число, которое необходимо найти в массиве ");
int number = int.Parse(Console.ReadLine()!);
int[] array = CreateRandomArray(5);
PrintArray(array);
Console.WriteLine();
if (LookForExact(array, number))
Console.WriteLine("yes");
else Console.WriteLine("no");


int[] CreateRandomArray(int size)
{
    int[] numbers = new int[size];
    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(0, 11);
    }
    return numbers;
}

void PrintArray(int[] numbers)
{
    foreach (int number in numbers)
    {
        Console.Write($"{number} ");
    }
}

bool LookForExact(int[] numbers, int number)
{
    bool check = false;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == number) check = true;
    }
    return check;
}
