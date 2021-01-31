using System;

namespace MyDictionaryHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> words = new MyDictionary<string>();

            words.Add("Apple");

            Console.WriteLine(words.Length);

            words.Add("Banana");

            Console.WriteLine(words.Length);

            foreach (var word in words.Items)
            {
                Console.WriteLine(word);
            }
        }
    }
}
