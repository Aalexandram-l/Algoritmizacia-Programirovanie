/*
задание на лабу 
    массивы 
    1.дан массив из н элементов состоящий из переменных целого типа 
    необходимо определить :
    все ли элементы в порядке воззрастание(да/нет)
    2.определить количество элементов значение которых оканчивается на 3
    3.для каждого элемента найти сумму цифр 
    4.определить ср ареф четных элементов массива 
1
using System;
using System.Drawing;
class Programm1
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine()), n3 = 0;
        bool n1 = true;
        int[] a = new int[n];
        Console.WriteLine("Введите элементы массива");
        for (int i=0; i < n; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 1; i < n; i++)
        {
            if (a[i] < a[i-1])
            {
                n1 = false;
            }
        }
        if (n1== true)
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }

    }
}
2
using System;
using System.Drawing;
class Programm2
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine()), n3 = 0;

        int[] a = new int[n];
        Console.WriteLine("Введите элементы массива");
        for (int i = 0; i < n; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            if (Math.Abs(a[i]) % 10 == 3)
            {
                n3++;
            }
        }
        Console.WriteLine(n3);

    }
}
3
using System;
using System.Drawing;
class Programm3
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine()), n3 = 0;

        int[] a = new int[n];
        Console.WriteLine("Введите элементы массива");
        for (int i = 0; i < n; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            n3 = 0;
            while (a[i] != 0)
            {
                n3 = n3 + (Math.Abs(a[i]))%10;
                a[i] = (Math.Abs(a[i]))/10;
            }
            Console.WriteLine(n3);
        }
        

    }
}

using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
class Programm4
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine()), n3 = 0,sumn=0;

        int[] a = new int[n];
        Console.WriteLine("Введите элементы массива");
        for (int i = 0; i < n; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            if (Math.Abs(a[i]) % 2 == 0)
            {
                n3++;
                sumn += a[i];
            }
        }
        Console.WriteLine(sumn/n3);

    }
}*/
