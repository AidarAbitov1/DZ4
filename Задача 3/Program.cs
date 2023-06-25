// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();
int [] array = new int [8];
FillArray(array);
PrintArray(array);

void FillArray(int[] array1)
{
    Random rnd = new Random();
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = rnd.Next(1, 100) ;
    }
}

void PrintArray(int[] array1)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array1[i] + ", ");
    }
}
