using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SozTezliyiSaygaci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();
            string[] words = text.Split(new char[] { ' ', '.', ',', ';', ':', '!', '?', '-', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> wordFrequencies = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (wordFrequencies.ContainsKey(word))
                {
                    wordFrequencies[word]++;
                }
                else
                {
                    wordFrequencies[word] = 1;
                }
            }
            Console.WriteLine("Word Frequencies:");
            foreach (KeyValuePair<string, int> pair in wordFrequencies)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }

            Console.ReadLine();
        }

    
    }
}
