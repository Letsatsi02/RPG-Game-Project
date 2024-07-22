using System;
using System.Collections.Generic;
using System.Linq;

public class WordLadder
{
    public int LadderLength(string startWord, string endWord, IList<string> wordList)
    {
        var wordSet = new HashSet<string>(wordList);
        if (!wordSet.Contains(endWord)) return 0;

        var queue = new Queue<string>();
        queue.Enqueue(startWord);
        var visited = new HashSet<string> { startWord };
        int level = 1;

        while (queue.Count > 0)
        {
            int size = queue.Count;
            for (int i = 0; i < size; i++)
            {
                string currentWord = queue.Dequeue();
                if (currentWord == endWord) return level;

                foreach (string nextWord in GetNextWords(currentWord, wordSet))
                {
                    if (!visited.Contains(nextWord))
                    {
                        queue.Enqueue(nextWord);
                        visited.Add(nextWord);
                    }
                }
            }
            level++;
        }

        return 0;
    }

    private IEnumerable<string> GetNextWords(string word, HashSet<string> wordSet)
    {
        for (int i = 0; i < word.Length; i++)
        {
            for (char c = 'a'; c <= 'z'; c++)
            {
                if (c == word[i]) continue;
                string nextWord = word.Substring(0, i) + c + word.Substring(i + 1);
                if (wordSet.Contains(nextWord)) yield return nextWord;
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        WordLadder wordLadder = new WordLadder();
        IList<string> wordList = new List<string> { "hot", "dot", "dog", "lot", "log", "cog" };
        Console.WriteLine(wordLadder.LadderLength("hit", "cog", wordList)); // 5

        wordList = new List<string> 
    }