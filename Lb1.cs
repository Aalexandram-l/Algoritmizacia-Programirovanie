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


*/