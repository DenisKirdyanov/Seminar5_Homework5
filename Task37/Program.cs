// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
//            Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

int[] array = GetArray(8, -10, 10);

foreach (int i in array)
{
    Console.Write($"  {i}  ");
}

Console.WriteLine();

void Change(int[] locArray)
{
    int[] k = new int[locArray.Length / 2];
    for (int i = 0; i < locArray.Length / 2; i++)
    {
        k[i] = locArray[i] * locArray[locArray.Length - i - 1];
    }
    foreach (int i in k)
    {
        Console.Write($"  {i}  ");
    }
}

Change(array);