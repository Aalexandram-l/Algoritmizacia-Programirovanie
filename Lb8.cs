/* 
лб 11.11
 задание 
на вход подается строка состоящая из слов между которыми от1 до нескольких пробелов
для заданной строки выполнить
удалить все лишние пробелы(оставить по одному)
выдать все слова палиндромы 
подсчитать колво слов у которых первый и последний символ совпадают



 
using System;

class programm
{
    static bool Palindrom(string str)
    {
        string newst= str.ToLower();
        for (int i = 0; i < newst.Length; i++)
        {
            if (newst[i] != newst[newst.Length - i - 1]) return false;
        }
        return true;
    }
    static bool GetChar(string str)
    {
        string newst = str.ToLower();
        if (newst [0] == newst[newst.Length - 1]) return true;
        return false;

    }
    
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string str = Console.ReadLine();

        string probel = "";
        bool inWord = false;
        
        
        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];

            if (ch != ' ')
            {
                probel += ch;
                inWord = true;
            }
            else if (inWord)
            {
                probel += ' ';
                inWord = false;
            }
        }
        int Kolvo = 0;
        Console.WriteLine("После удаления лишних пробелов: ");
        Console.WriteLine(probel);
        string[] newstr = probel.Split(' ');
        Console.WriteLine("Палиндромы: ");
        foreach (string st  in newstr)
        {
            if (Palindrom(st))
            {
                Console.WriteLine(st);
            }
            if (GetChar(st))
            {
                Kolvo++;
            }
        }
        Console.WriteLine($"Количество слов, у которых первый и последний символы совпадают: {Kolvo}");

    }
}

*/