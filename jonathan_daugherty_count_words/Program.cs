using System;
using System.Collections.Generic;

namespace jonathan_daugherty_count_words {

    class Program {

        static void Main(string[] args) {

            // read all the text into a single string
            var text = System.IO.File.ReadAllText("/Users/gpdoud/Repos/jonathan_daugherty_count_words/jonathan_daugherty_count_words/textfile.txt");
            // split the string into words
            var words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            // dictionary to count the words
            var dict = new Dictionary<string, int>();
            foreach(var word in words) {
                // does the dictionary currently contain the word?
                if(!dict.ContainsKey(word)) {
                    // if not, add it with a count set to 1
                    dict.Add(word, 1);
                    continue;
                }
                // if so, add 1 to the number of occurances
                dict[word]++;
            }
            foreach(var key in dict.Keys) {
                Console.WriteLine($"{key} {dict[key]}");
            }
        }
    }
}
