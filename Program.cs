using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string text= "Це Приклад тексту з Словами, які Починаються з Великої літери. Another Example Here.";

        // Регулярний вираз для слів з великої літери
        Regex regex = new Regex(@"\b[A-ZА-ЯЇІЄҐ][a-zа-яїієґ]*\b");

        List<string> wordsWithCapital = new List<string>();

        MatchCollection matches = regex.Matches(text);

        foreach (Match match in matches)
        {
            wordsWithCapital.Add(match.Value);
        }

        // Вивід результатів
        Console.WriteLine("\nСлова з великої літери:");
        foreach (string word in wordsWithCapital)
        {
            Console.WriteLine(word);
        }
    }
}
