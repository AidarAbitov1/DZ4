// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11

Console.Clear();
Console.WriteLine("Введите число А");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = SumNumbers(numberA);
Console.WriteLine(numberB);
int  SumNumbers(int B)
{
    int a = 0;
    while (B != 0)
    {
        B = B / 10;
        a++;
    }
    return a;
}