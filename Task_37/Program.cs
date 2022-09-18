// 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 9
// [6 7 3 6] -> 36 21

Console.Write("Введите количество элементов массива ");
int size = int.Parse(Console.ReadLine()!);
int[] array = CreateRandomArray(size);
PrintArray(array);
int[] NewArray = MultipliesArray(array);
PrintArray(NewArray);

int[] CreateRandomArray(int size)
{
    int[] numbers = new int[size];
    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(1, 10);
    }
    return numbers;
}

void PrintArray(int[] numbers)
{
    foreach (int number in numbers)
    {
        Console.Write($"{number} ");
    }
    Console.WriteLine();
}

int[] MultipliesArray(int[] array)
{
    int sizeNew = (array.Length + 1) / 2;
    int[] arrayNew = new int[sizeNew];
    int size = array.Length;
    for (int i = 0; i < sizeNew; i++)
    {
        arrayNew[i] = array[i] * array[size - i - 1];
    }
    return arrayNew;
}