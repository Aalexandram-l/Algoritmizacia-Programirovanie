/*лр3
 дана последовательность из н элементов
1.определить максимальный размер подпоследовательноти(рядом стоящие элементы удов условия) состоящей из одинаковых элементов
2 определить минимальную длину подпоследовательностей из нулей
3 неопходимо определить макс сумму подпоследовательностей из четных чисел 


using System;
using System.Drawing;

class Programm1
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine()), el2, colvo = 1, colv1 = 1, el = 1;
        el2 = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i < n; i++)
        {
            el = Convert.ToInt32(Console.ReadLine());

            if (el == el2)
            {
                colvo++;

            }
            else if (el != el2)
            {
                colv1 = Math.Max(colvo++, colv1);
                colvo = 1;
            }
            el2 = el;
        }

        colv1 = Math.Max(colvo++, colv1);

        Console.WriteLine(colv1);


    }
}

2.
using System;
using System.Drawing;

class Programm2
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int minlen = n;
        int curlen = 0;
        for (int i = 0; i < n; i++)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 0) curlen++;
            else
            {
                minlen = curlen > 0 ? Math.Min(curlen, minlen) : minlen;
                curlen = 0;
            }
        }
        minlen = minlen > 0 ? Math.Min(curlen, minlen) : minlen;
        Console.WriteLine(minlen);
    }
}

3. 
using System;
using System.Drawing;

class Programm3
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int maxsum = -1000000;
        bool maxEmpty = true;
        int cursum = 0;
        bool curEmpty = true;

        for (int i = 0; i < n; i++)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            if (Math.Abs(number) % 2 == 0)
            {
                cursum += number;
                curEmpty = false;
            }
            else if (maxEmpty)
            {
                maxsum = cursum;
                cursum = 0;
                curEmpty = true;
            }
            else
            {
                maxsum = curEmpty ? maxsum : Math.Max(cursum, maxsum);
                cursum = 0;
                curEmpty = true;
            }
            Console.WriteLine($"{number}\t{cursum}\t{maxsum}");
        }

        if (maxEmpty && curEmpty)
        {
            Console.WriteLine("Нет чётных");
        }
        else
        {
            maxsum = curEmpty ? maxsum : Math.Max(cursum, maxsum);
            Console.WriteLine(maxsum);
        }
    }
}*/