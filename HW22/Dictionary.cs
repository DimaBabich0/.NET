using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW22
{
    internal class Word
    {
        public string English { get; set; }
        public List<string> French { get; set; }

        public Word(string word)
        {
            English = word;
            French = new List<string>();
        }
    }

    internal class EnglishFrenchDictionary
    {
        public Dictionary<string, Word> Dictionary { get; private set; } = new Dictionary<string, Word>();
        public EnglishFrenchDictionary()
        {
            Dictionary = new Dictionary<string, Word>();
        }
        
        public void AddWord(string english, string french)
        {
            if (!Dictionary.ContainsKey(english))
            {
                Dictionary[english] = new Word(english);
            }
            Dictionary[english].French.Add(french);
        }
        
        public void AddWord(string english, params string[] french)
        {
            if (!Dictionary.ContainsKey(english))
            {
                Dictionary[english] = new Word(english);
            }
            Dictionary[english].French.AddRange(french);
        }
        
        public void RemoveWord(string english)
        {
            if (Dictionary.ContainsKey(english))
            {
                Dictionary.Remove(english);
                Console.WriteLine($"Word \"{english}\" removed");
            }
            else
            {
                Console.WriteLine($"Word \"{english}\" not found");
            }
        }
        
        public void RemoveFrenchTranslation(string english, string french)
        {
            if (Dictionary.ContainsKey(english))
            {
                var word = Dictionary[english];
                if (word.French.Contains(french))
                {
                    word.French.Remove(french);
                    Console.WriteLine($"Translation \"{french}\" for word \"{english}\" removed");
                }
                else
                    Console.WriteLine($"Translation \"{french}\" for word \"{english}\" not found");
            }
            else
                Console.WriteLine($"Word \"{english}\" not found");
        }
        
        public void ModifyWord(string old_english, string new_english)
        {
            if (Dictionary.ContainsKey(old_english))
            {
                var word = Dictionary[old_english];
                Dictionary.Remove(old_english);
                word.English = new_english;
                Dictionary[new_english] = word;
                Console.WriteLine($"Word \"{old_english}\" changed to \"{new_english}\".");
            }
            else
                Console.WriteLine($"Word \"{old_english}\" not found");
        }
        
        public void EditFrenchTranslation(string english, string old_french, string new_french)
        {
            if (Dictionary.ContainsKey(english))
            {
                var word = Dictionary[english];
                if (word.French.Contains(old_french))
                {
                    int index = word.French.IndexOf(old_french);
                    word.French[index] = new_french;
                    Console.WriteLine($"Translation \"{old_french}\" changed to \"{new_french}\" for word \"{english}\"");
                }
                else
                    Console.WriteLine($"Translation \"{old_french}\" fro word \"{english}\" not found");
            }
            else
                Console.WriteLine($"Слово \"{english}\" не найдено.");
        }
        
        public void SearchTranslation(string english)
        {
            if (Dictionary.TryGetValue(english, out Word value))
            {
                Word word = value;
                Console.WriteLine($"Translations for word \"{english}\":");
                foreach (var french in word.French)
                {
                    Console.WriteLine(french);
                }
            }
            else
                Console.WriteLine($"Word \"{english}\" not found");
        }
    }
}
