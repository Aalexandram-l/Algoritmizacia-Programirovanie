/*
 лб 25.11
 на вход строка
1 необходмо определить самый частый символ а*б приэтом регистор не имеет значения
2 только маленькие буквы определить наибольшую длину подпоследовательности абс
 
1.
using System;
class Programm
{
    static void Main()
    {
        string tex = Console.ReadLine();
        string text = tex.ToLower();
        Console.WriteLine(text);
        char[] ch = text.ToCharArray();
        int maxCount = -1;
        char character = ' ';
        int[] charCount = new int[256];
        int length = text.Length;
        Console.WriteLine(length);
        for (int i = 1; i < length-1; i++)
        {
            if ((text[i-1] == 'a') && (text[i+1] == 'b'))
            {
                charCount[text[i]]++;
            }
            
        }
        for (int i = 1;i < ch.Length-1;i++)
        {
            if ((ch[i - 1] == 'a') && (ch[i + 1] == 'b'))
            {
                if (maxCount < charCount[text[i]])
                {
                    maxCount = charCount[text[i]];
                    character = text[i];
                }
            }
        }
        Console.WriteLine($"Самый частый символ: {character} - {maxCount}");
    }
}
2.
using System;
class Programm
{
    static void Main()
    {
        string tex = Console.ReadLine();
        string text = tex.ToLower();
        int maximum = 0;
        string alf = "qwertyuiopsdfghjklzxvnm";
        foreach(char c in alf)
        {
            text = text.Replace(c, ' ');
        }
        Console.WriteLine(text);
        string[] newtext = text.Split(' ');
        for (int i = 0; i < newtext.Length; i++)
        {
            if (newtext[i].Length > maximum)
            {
                maximum = newtext[i].Length;
            }
        }
        Console.WriteLine(maximum);
        
    }
}
*/