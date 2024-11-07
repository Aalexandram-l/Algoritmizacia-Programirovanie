/*
28.10
пз
задания
массив трех массивов 
у каждого массива своя размерность
необходимо определить колво нечетных элементов каждой строки массива
нахождение колличества с помощью функции

using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
class Programm1
{

    static int Proz(int[] numbers)
    {
        int pros = 0;
        foreach (int n in numbers)
        {
            if (n % 2 != 0)
            {
                pros += 1;
            }
        }
        return pros;
    }

    static void Main()
    {
        int pN = 0, pM = 0, pP = 0;
        int[][] A = new int[3][];
        Console.WriteLine("Введите длину 1-й строки массива");
        int n0 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите длину 2-й строки массива");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите длину 3-й строки массива");
        int n2 = Convert.ToInt32(Console.ReadLine());
        A[0] = new int[n0];
        A[1] = new int[n1];
        A[2] = new int[n2];

        Console.WriteLine("Введите элементы массива");
        for (int i = 0; i < n0; i++)
        {
            A[0][i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Введите элементы массива");
        for (int i = 0; i < n1; i++)
        {
            A[1][i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Введите элементы массива");
        for (int i = 0; i < n2; i++)
        {
            A[2][i] = Convert.ToInt32(Console.ReadLine());
        }
        pN = Proz(A[0]);
        pM = Proz(A[1]);
        pP = Proz(A[2]);
        Console.WriteLine($"Количество нечетных элементов 1-й строки массива: {pN} ");
        Console.WriteLine($"Количество нечетных элементов 2-й строки массива: {pM} ");
        Console.WriteLine($"Количество нечетных элементов 3-й строки массива: {pP} ");



    }
}*/