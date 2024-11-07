/*лаб 2(16.09)

using System;
class Programm
{
    static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        if (a >= 0) Console.WriteLine("+");
        else Console.WriteLine("-");
    }
}

using System;
class Programm
{
    static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <= a; i++)
        {
            Console.WriteLine("***");
            Console.WriteLine(i);
        }

    }
}

дана последовательность элементов в количестве n(>3)
задание 1: 
определить количество элементов меньших 0
задание 2:
определить среди элементов второй мах элемент
задание 3:
определить количество элементов являющиеся локальными min элементами(знач меньше двух соседов)


1.
using System;
class Programm1
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine()), Shet = 0;
        for (int i = 0; i < n; i++)
        {
            int elem = Convert.ToInt32(Console.ReadLine());
            if (elem < 0) Shet += 1;
        }
        Console.WriteLine(Shet);
    }
}


2.
using System;
class Programm2
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine()), maxi2 = 0, maxi1 = 0;
        for (int i = 0; i < n; i++)
        {
            int elem = Convert.ToInt32(Console.ReadLine());

            if (elem >= maxi1)
            {
                maxi2 = maxi1;
                maxi1 = elem;
            }
            else if (elem >= maxi2)
            {
                maxi2 = elem;
            }
        }
        Console.WriteLine(maxi2);
    }
}


3.
using System;
class Programm3
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine()), colv0 = 0, fr, sc, tr;
        fr = Convert.ToInt32(Console.ReadLine());
        sc = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < n - 1; i++)
        {

            tr = Convert.ToInt32(Console.ReadLine());
            if ((sc < tr) && (sc < fr))
            {
                colv0++;
            }
            fr = sc;
            sc = tr;
        }
        Console.Write("Количество локальных минимумов: ");
        Console.WriteLine(colv0);
    }
}*/