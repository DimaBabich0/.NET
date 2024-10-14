using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW05
{
    internal class Program
    {
        static void Task1()
        {
            Console.WriteLine("Enter text:");
            string userText = Console.ReadLine();

            Console.Write("Enter number of shift (0 - 25): ");
            int shift = Convert.ToInt32(Console.ReadLine());
            if (shift < 0 || shift > 25)
            {
                Console.WriteLine("Wrong number");
                return;
            }

            StringBuilder result = new StringBuilder();
            Console.WriteLine("1 - cipher, 2 - decipher: ");
            int action = Convert.ToInt32(Console.ReadLine());
            if (action != 1 && action != 2)
            {
                Console.WriteLine("Wrong input");
                return;
            }

            if (action == 2)
            {
                shift = 26 - (shift % 26);
            }

            foreach (char ch in userText)
            {
                if (char.IsLetter(ch))
                {
                    char baseChar = char.IsUpper(ch) ? 'A' : 'a';
                    char transformedChar = Convert.ToChar(((((ch - baseChar) + shift) % 26) + baseChar));
                    result.Append(transformedChar);
                }
                else
                {
                    result.Append(ch);
                }
            }

            if (action == 1)
            {
                Console.WriteLine($"Ciphered: {result}");
            }
            else
            {
                Console.WriteLine($"Deciphered: {result}");
            }
        }
        static void Task2()
        {
            Console.WriteLine("Enter the math expression:");
            string str = Console.ReadLine();

            string clearStr = str.Replace(" ", "");
            string[] numbers = clearStr.Split(new char[] { '+', '-' }, StringSplitOptions.RemoveEmptyEntries);

            string[] splitNum = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string[] operations = clearStr.Split(splitNum, StringSplitOptions.RemoveEmptyEntries);

            int result = Convert.ToInt32(numbers[0]);
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (operations[i] == "+")
                {
                    result += Convert.ToInt32(numbers[i + 1]);
                }
                else if (operations[i] == "-")
                {
                    result -= Convert.ToInt32(numbers[i + 1]);
                }
            }
            Console.WriteLine($"Result of expression {str} = {result}");
        }
        static void Task3()
        {
            Console.WriteLine("Enter few sentences in low register: ");
            string str = Console.ReadLine();
            Console.WriteLine();

            string[] sentences = str.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            string result = "";

            foreach (var sentence in sentences)
            {
                string trimmedSentence = sentence.Trim();
                if (!string.IsNullOrEmpty(trimmedSentence))
                {
                    result += char.ToUpper(trimmedSentence[0], CultureInfo.InvariantCulture) + trimmedSentence.Substring(1) + ". ";
                }
            }
            Console.WriteLine($"Original paragraph:\n{str}");
            Console.WriteLine($"Updated paragraph:\n{result}");
        }
        static void Task4()
        {
            string userText;

            Console.WriteLine("Enter you're text:");
            userText = Console.ReadLine();

            List<string> banWords = new List<string>();
            Console.WriteLine("Enter the invalid words one by one. Press \"Enter\" without words to finish typing");
            while (true)
            {
                Console.Write("Enter invalid word: ");
                string word = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(word))
                {
                    if (banWords.Count > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The list of invalid words is empty. Enter at least one word");
                        continue;
                    }
                }
                banWords.Add(word.Trim());
            }

            char[] punctuationMarks = { ' ', '.', ',', '!', '?', ';', ':', '-', '\"', '\'', '(', ')' };
            string result = "";
            int count = 0;

            string currentWord = "";
            foreach (char ch in userText)
            {
                if (char.IsLetter(ch))
                {
                    currentWord += ch;
                }
                else
                {
                    if (currentWord.Length > 0)
                    {
                        bool isBanned = false;
                        foreach (string banWord in banWords)
                        {
                            if (string.Equals(currentWord, banWord, StringComparison.OrdinalIgnoreCase))
                            {
                                result += new string('*', currentWord.Length);
                                count++;
                                isBanned = true;
                                break;
                            }
                        }
                        if (!isBanned) result += currentWord; 
                        currentWord = "";
                    }
                    result += ch;
                }
            }
            if (currentWord.Length > 0)
            {
                bool isBanned = false;
                foreach (string word in banWords)
                {
                    if (string.Equals(currentWord, word, StringComparison.OrdinalIgnoreCase))
                    {
                        result += new string('*', currentWord.Length);
                        count++;
                        isBanned = true;
                        break;
                    }
                }
                if (!isBanned) result += currentWord;
            }

            Console.WriteLine("Result:");
            Console.WriteLine(result.ToString());
            Console.WriteLine($"{count} words replaced");
        }

        static void Main()
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }
    }
}
