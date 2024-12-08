/*
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
        Console.WriteLine("Введите количество строк");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов");
        int m = Convert.ToInt32(Console.ReadLine());
        int[,] A = new int[n,m];
        
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < m; j++)
            {
                Console.Write("Введите {0},{1} элемент  массива ", i + 1, j + 1);
                A[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int min = A[1, 1];
        int max = A[1, 1];
        int minstr = 0, maxstr = 0;

        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] < min)
                {
                    min = A[i, j];
                    minstr = i;
                }
            }
        }


        for (int i = 1; i < n; i++)
        {
            for(int j = 0; j < m; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxstr = i;
                }
            }
        }
        Console.WriteLine("Меняем местами строки {0} и {1} строку ",minstr+1,maxstr+1);
        int[] tempmas = new int[n];
        for (int i = minstr, j = 0, k = 0; j < m; j++, k++)
        {
            tempmas[k]= A[i, j];
        }

        for (int j = 0; j < m; j++)
        {
            A[minstr, j] = A[maxstr, j];
        }

        for (int j = 0; j < m; j++)
        {
            A[maxstr, j] = tempmas[j];
        }
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < m; j++)
            {
                Console.Write(A[i, j]+"\t");
            }
            Console.WriteLine();
        }

    }
}

2.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
class Programm2
{

    static void Main()
    {
        Console.WriteLine("Введите количество строк ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов ");
        int m = Convert.ToInt32(Console.ReadLine());
        int[,] A = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("Введите {0},{1} элемент  массива ", i + 1, j + 1);
                A[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        
        int min = 100000;
        int max = -1;
        int [] Mini = new int[n], Maxi= new int [n];
        
        for (int i = 0; i < n; i++)
        {
            min = 100000;
            max = -1;

            for (int j = 0; j < m; j++)
            {
                if (A[i, j] <= min)
                {
                    min = A[i, j];
                }
                if (A[i, j] >= max)
                {
                    max = A[i, j];
                }
                
            }
            Mini[i] = min;
            Maxi[i] = max;
            Console.WriteLine();
        }
        Console.WriteLine(" n:   min:  max:");
        for (int k = 0; k < n; k++)
        {
            Console.WriteLine("{0,2}){1,6}{2,6}", k + 1, Mini[k], Maxi[k]);
        }
  
        
        int minc = 100000;
        int maxc = -1;
        int[] Minic = new int[m], Maxic = new int[m];
        for (int i = 0; i < m; i++)
        {
            minc = 100000;
            maxc = -1;

            for (int j = 0; j < n; j++)
            {
                if (A[j, i] <= minc)
                {
                    minc = A[j, i];
                }
                if (A[j, i] >= maxc)
                {
                    maxc = A[j, i];
                }

            }
            Minic[i] = minc;
            Maxic[i] = maxc;
            Console.WriteLine();
        }
        Console.WriteLine(" m:   min:  max:");
        for (int k = 0; k < m; k++)
        {
            Console.WriteLine("{0,2}){1,6}{2,6}", k + 1, Minic[k], Maxic[k]);
        }
  
        
    }
}
3.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
class Programm3
{
    static int Maxi(int[,] array,int n,int m)
    {
        int max = array[1, 1];
        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (array[i, j] > max)
                {
                    max = array[i, j];
                }
            }
        }
        return max;

    }
    static bool AreRowsEqual(int[,] array, int row1, int row2)
    {
        int numColumns = array.GetLength(1);

        int maxValue = Maxi(array,array.GetLength(0), array.GetLength(1));
        
        
        int[] count1 = new int[maxValue + 1]; 
        int[] count2 = new int[maxValue + 1]; 

        for (int col = 0; col < numColumns; col++)
        {
            count1[array[row1, col]]++;
            count2[array[row2, col]]++;
        }

        for (int i = 0; i <= maxValue; i++)
        {
            if (count1[i] != count2[i])
                return false;
        }

        return true;
    }

    static void Main()
    {
        Console.WriteLine("Введите количество строк ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов ");
        int m = Convert.ToInt32(Console.ReadLine());
        int[,] A = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("Введите {0},{1} элемент  массива ", i + 1, j + 1);
                A[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++) 
            {
                if (AreRowsEqual(A, i, j))
                {
                    Console.WriteLine($"Строки {i} и {j} одинаковы.");
                }
            }
        }

    }
}

*/

