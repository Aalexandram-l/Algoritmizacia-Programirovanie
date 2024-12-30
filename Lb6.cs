/*
 28.10
лб
массив двумерный н*м

задание 1
необходимо переставить строку с мин элементом со строкой с макс элементом
минимум и макс одни

задание 2
необходимо определить  массиве точки минимакса (число минимальное в строке и максимальное в столбце
или наоборот число максимальное в строке и минимальное в столбце)

задание 3
необходимо выдать пары номеров строк состоящих из одинаковых элементов(нельзя сортировать)

1
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

2
using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
class Programm2
{
    private static void SaddlePoints(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (!IsMinInRow(array, i, j) || !IsMaxInCol(array, i, j)) continue;
                Console.WriteLine("    Элемент {0} является минимаксом.", array[i, j]);
                Console.WriteLine("Строка: {0}\tстолбец: {1}", i + 1, j + 1);
            }
        }
    }

    private static bool IsMaxInCol(int[,] array, int i, int j)
    {
        for (int k = 0; k < array.GetLength(0); k++)
        {
            if (array[k, j] > array[i, j])
                return false;
        }
        return true;
    }

    private static bool IsMinInRow(int[,] array, int i, int j)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            if (array[i, k] < array[i, j])
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
        SaddlePoints(A);
        

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
