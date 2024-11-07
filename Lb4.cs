/*лр 4
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
        int n = Convert.ToInt32(Console.ReadLine()), n1 = 0, n3 = 0;
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
            if ((n1 == 0) && (n3 == 0))
            {
                Console.WriteLine("нет четных");
            }
            else if ((n1 == 0) && (n3 == 1))
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(n1);
            }
            n = Convert.ToInt32(Console.ReadLine());
            n1 = 0;
        } while (n > 0);

    }
}
*/