/*пк 16.10
задание 
даны три массива размерностью н, м и п 
в каждом массиве определить сумму элементов кратных трем (функция)
произведение нечетных элементов (функция)
колличество нулевых элементов (функция)
заполнение массивов выполнить функцией 

*/
using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
class Programm1
{
    static int[] Maseve()
    {
        Console.WriteLine("Введите длину массива:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[n];
        Console.WriteLine("Введите элементы массива");
        for (int i = 0; i < n; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Массив заполнен.");
        return a;
    }
    static int Summe3(int[] numbers)
    {
        int sumn = 0;
        foreach (int n in numbers)
        {
            if (n % 3 == 0)
            {
                sumn += n;
            }
        }
        return sumn;
    }
    static int Proz(int[] numbers)
    {
        int pros = 1;
        foreach (int n in numbers)
        {
            if (n % 2 != 0)
            {
                pros *= n;
            }
        }
        return pros;
    }
    static int Nuli(int[] numbers)
    {
        int resu = 0;
        foreach (int n in numbers)
        {
            if (n == 0)
            {
                resu += 1;
            }
        }
        return resu;
    }
    static void Main()
    {
        int suN = 0, suM = 0, suP = 0, pN = 0, pM = 0, pP = 0, oN = 0, oM = 0, oP = 0;

        int[] N = Maseve();
        int[] M = Maseve();
        int[] P = Maseve();

        pN = Proz(N);
        pM = Proz(M);
        pP = Proz(P);

        suN = Summe3(N);
        suM = Summe3(M);
        suP = Summe3(P);

        oN = Nuli(N);
        oM = Nuli(M);
        oP = Nuli(P);

        Console.WriteLine($"Сумма элементов кратных трем массива 1: {suN} ");
        Console.WriteLine($"Сумма элементов кратных трем массива 2: {suM} ");
        Console.WriteLine($"Сумма элементов кратных трем массива 3: {suP} ");

        Console.WriteLine($"Произведение нечетных элементов массива 1: {pN} ");
        Console.WriteLine($"Произведение нечетных элементов массива 2: {pM} ");
        Console.WriteLine($"Произведение нечетных элементов массива 3: {pP} ");

        Console.WriteLine($"Количество нулевых элементов массива 1: {oN} ");
        Console.WriteLine($"Количество нулевых элементов массива 2: {oM} ");
        Console.WriteLine($"Количество нулевых элементов массива 3: {oP} ");
    }
}