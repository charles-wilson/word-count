using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniqueWordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var statement = "As an author I want to know the number of times each word appears in a sentence So that I can make sure I'm not repeating myself";
            string[] words = statement.Split(' ');
            var unique = from a in words group a by a into c select new { word = c.Key, count = c.Count() };
            foreach (var item in unique.ToList())
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
