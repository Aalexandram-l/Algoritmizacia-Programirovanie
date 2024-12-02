/*08.11
задания
на вход зубчатый массив 
необходимо с помощью функции орг ввод каждой строки массива(размерность строк различ)
определить номера строк элементы в которых образуют равномерно убывающуюю последовательность 

using System;
class Programm1
{
    static int[][] Maseve()
    {
        Console.WriteLine("Введите длину массива:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] A = new int[n][];
        for (int i = 0; i < n; i++)
        {
            int n0 = 0;
            Console.WriteLine($"Введите длину {i}-й строки массива");
            n0 = Convert.ToInt32(Console.ReadLine());
            A[i] = new int[n0];
            Console.WriteLine("Введите элементы массива");
            for (int j = 0; j < n0; j++)
            {
                A[i][j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        
        return A;
    }
    static bool Proverka(int[] row)
    {
        int r = row[0]-row[1];
        for(int i = 1; i < row.Length; i++)
        {
            if ((row[i] >= row[i - 1]) || (row[i - 1] - row[i] != r))
            {
                return false;
            }
        }
        return true;
    }
    static void Main()
    {
        int[][] D = Maseve();


        for (int i = 0; i < D.Length; i++)
        {
            if (Proverka(D[i]))
            {
                Console.WriteLine($"Строка {i} равномерно убывающая");
            }
        }
    }
    
}*/