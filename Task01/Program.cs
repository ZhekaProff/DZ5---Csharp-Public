// Написать программу копирования массива

Console.Clear();

void RandomArray(int[] array) // заполняем массив рандомными числами 
{
    int length = array.Length; // определяем длинну массива
    for(int i = 0; i < length; i++ )
    {
        array[i] = new Random().Next(0, 10);     
    }
}

void PrintArray(int[] array) // функция печати массива
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

//========================Решение=============================

int[] array = new int[10];
int array2;

Console.Write("Оригинал ");
RandomArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write("   Копия ");
for (int i = 0; i < array.Length; i++)
{
    array2 = array[i];
    Console.Write(array2 + " ");
}