//Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 50);
        index++;
    }
}

void PrintArray(int[] coll)
{
    int count = coll.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.Write(coll[pos] + " ");
        pos++;
    }

}
int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine(" ");

int max = array[0];
int min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
int raznitsa = max - min;
Console.WriteLine($"Разница между максимальным ({max}) и минимальным ({min}) числами в массиве равна: {raznitsa}");