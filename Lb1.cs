/*1 на вход подается а и б из этих двух значений (без третьей) поменять их значениями*/
/*2 на вход две переменные найти минимум из двух значений*/
/*3 н грядок л - ширина м- высота к-расстояние от колодца до первой грядки , найти дллину пути 
 
 
 l=3 m=3 k=5 n=1 s22, n=2 s=50 n=3 s84 n=4 s124 n=10 s490*/
/*
 

лаб 1(13.09)
using System;
class Programm1
{
    static void Main()
    {
        int first, second;
        first = Convert.ToInt32(Console.ReadLine());
        second = Convert.ToInt32(Console.ReadLine());
        first= first+second;
        second= first - second;
        first= first - second;
        Console.WriteLine(first);
        Console.WriteLine(second);

    }
}


using System;
using System.Xml.Schema;
class Programm2
{
    static void Main()
    {
        int first, second,minu;
        first = Convert.ToInt32(Console.ReadLine());
        second = Convert.ToInt32(Console.ReadLine());
        minu = ((first + second) - Math.Abs(first - second))/2;
        Console.WriteLine(minu);
    }
}



using System;
class Programm3
{
    static void Main()
    {
        int k = 5, m = 3, l = 3, N, S;
        N = Convert.ToInt32(Console.ReadLine());
        S = ((2 * ((l + m) * 2 + k * 2) + (l * 2) * (N - 1)) / 2) * N;
        Console.WriteLine(S);

    }

}


лаб 2(16.09)

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
        int n = Convert.ToInt32(Console.ReadLine()),Shet=0;
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
        int n = Convert.ToInt32(Console.ReadLine()), maxi2 = 0,maxi1=0;
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
        int n = Convert.ToInt32(Console.ReadLine()),colv0=0, fr, sc, tr;
        fr = Convert.ToInt32(Console.ReadLine());
        sc= Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < n-1; i++)
        {
            
            tr= Convert.ToInt32(Console.ReadLine());
            if ((sc<tr) && (sc < fr))
            {
                colv0++;
            }
            fr = sc;
            sc = tr;
        }
        Console.Write("Количество локальных минимумов: ");
        Console.WriteLine(colv0);
    }
}
лр3!!!
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
        int n = Convert.ToInt32(Console.ReadLine()),el2,colvo=1,colv1=1,el=1;
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

Задача 2. Мин подпоследовательность из 0
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
     
 Задача 3. Определить макс сумму подпоследовательности из чётных чисел
int n = Convert.ToInt32(Console.ReadLine());
int maxsum = 0;
bool maxEmpty = true;
int cursum = 0;
bool curEmpty = true;

for (int i = 0; i < n; i++)
{
    int number = Convert.ToInt32(Console.ReadLine());
    if (number % 2 == 0)
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
}
лр 4
1. ваил
дана последовательность целых положительных элементов 
необходимо каждое числовое значение последовательности перевернуть и удали все нечетные цифры в элементе 
если в элементе после удалеени не останется ни одной цифры выдать сообщение /нету четной/

using System;
using System.Drawing;
class Programm1
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine()),n1=0,n3=0;
        do
        {
            n3 = 0;
            while (n != 0)
            {
                if ((n % 10) % 2 == 0)
                {
                    n1 = n1 * 10 + (n % 10);
                    n3 = 1;
                }
                else
                {
                    n1 = n1 + 0;
                }
                n = n / 10;
            }
            if ((n1 == 0)&&(n3==0))
            {
                Console.WriteLine("нет четных");
            }
            else if ((n1==0)&&(n3==1))
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(n1);
            }
            n = Convert.ToInt32(Console.ReadLine());
            n1 = 0;
        } while (n>0);

    }
}


итоговая работа по ворду
    документ из нескольких разделов (отдельные листочки)
    на первом листочке оглавление собранное автоматически из заголовков разделов 
    оглавление 
    общие требования(и колантитулы):
    отступ верхний нижний и боковые 2 см
    шрифт тайм нью роман 14 
    интервал перед после 0
    доп требования 
    основной текст расстояние 1,5 
    для заголовков текстов таблицы расстояние одинарное 
    заколовки рзделов по центру полужирный большие буквы(раздел 1...)
    (отступ первой строки для заголовка не надо)
    раздел 1
    любая формула со степенью и деление 
    формула должна быть сделана с использованием встроенных в ворде формул
    раздел 2
    текст состоящий из 4 абзацев 
    межстрочный интервал полуторный 
    отступ первой строки 1 см выравнивание по ширине 
    в конце текста вставить любой маркированный список (отступ 1 см)
    раздел 3
    таблица из 5 столбцов 5 строк 
    заголовки таблицы(столбец 1 ...)
    расположение заголовков столбцов по центру относителльно вертикали и горизонтали
    в 4 по вертикале 
    в 1 оставшиеся четыре ячейки выстовить автоматическую нумерацию 
    раздел 4
    рисунок отображать блок схему алгоритма нахождения суммы двух переменных 
    рисунок сгруппировать и выставить обтикание сверху и снизу
    под рисунком подпись по центру (рисунок 1 - Блок схема)
    раздел 5(название список используемой литературы)
    список используемой литературы 
    автоматическая нумерация отступ первой строки нет
    полуторный 
    выравнивание  по ширине 
    в вернем колантитуле фио группа 
    нижний по центру номер страницы


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
}
пк 16.10
задание 
даны три массива размерностью н,м и п 
в каждом массиве определить сумму элементов кратных трем (функция)
произведение нечетных элементов (функция)
колличество нулевых элементов (функция)
заполнение массивов выполнить функцией 


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
            if (n==0)
            {
                resu += 1;
            }
        }
        return resu;
    }
    static void Main()
    {
        int suN = 0, suM = 0, suP = 0,pN=0,pM=0,pP=0,oN=0,oM=0,oP=0;

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
}
крестьянин и черт

using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
class Programm4
{
    static void Main()
    {
        int N = Convert.ToInt32(Console.ReadLine()), K=1, Z=1;

        while (N >0)
        {
            N = 2 * N - K;
            Z = Z + 1;

        }
        Console.WriteLine(K);

    }
}
for (int i = 0; i < n; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < m; j++)
            {
                Console.Write("{0}", A[i,j]);
                
            }
        }
28.10
лб
задание
массив двумерный н*м
необходимо переставить строку с мин элементом со строкой с макс элементом
минимум и макс одни
задание 2
необходимо определить точки минимакса
задание 3
необходимо выдать пары номеров строк состоящих из одинаковых элементов(нельзя сортировать)

using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
class Programm1
{
    static void Main()
    {
        int pN = 0, pM = 0, pP = 0;
        
        Console.WriteLine("Введите количество элементов");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество элементов");
        int m = Convert.ToInt32(Console.ReadLine());
        int[,] A = new int[n,m];
        
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < m; j++)
            {
                Console.Write("Введите {0},{1} элемент  массива", i + 1, j + 1);
                A[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        
        



    }
}
*/