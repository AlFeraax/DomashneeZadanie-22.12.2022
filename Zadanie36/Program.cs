// Задача 36.  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 25);
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

int sum = 0;
for (int i = 1; i < array.Length; i = i + 2)
{
    sum = sum + array[i];
}
Console.WriteLine($"Сумма элементов массива находящихся на нечетных позициях ({array[1]}, {array[3]}, {array[5]}, {array[7]}, {array[9]}) равна {sum}.");