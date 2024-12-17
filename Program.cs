using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите буквы: ");
        string input = Console.ReadLine();

        Console.WriteLine("Все возможные слова:");
        HashSet<string> words = new HashSet<string>();
        GeneratePermutations(input, "", words);

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }

    static void GeneratePermutations(string input, string current, HashSet<string> words)
    {
        if (input.Length == 0)
        {
            words.Add(current);
            return;
        }

        for (int i = 0; i < input.Length; i++)
        {
            string newCurrent = current + input[i];
            string newInput = input.Substring(0, i) + input.Substring(i + 1);
            GeneratePermutations(newInput, newCurrent, words);
        }
    }
}