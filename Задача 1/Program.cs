// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)

Console.Clear();
Console.WriteLine("Введите число А");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число B");
    int numberB = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(GetPow(numberA, numberB));

     int GetPow(int a, int b)
    {   int A = 1 ;
        for (int i = 1; i <= b; i++)
            checked { 
                A = a * a ;
            } 
        return A;
    }