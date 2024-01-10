using System;
using System.Text.RegularExpressions;
using ParsingFunction;

namespace Main
{
    class Program
    {
        private static string deleteIndex(string input)
        {
            string result = input;
            // check result have * in sentence
            while (result.IndexOf('*') >= 0)
            {
                int index = result.IndexOf('*');

                // If * is in position 0, delete itself.
                if (index == 0) result = result.Remove(index, 1);
                else
                {
                    char deleteChar = result[index - 1];
                    char checkChar = result[index - 1];
                    int checkIndex = index - 1;
                    int count = 1;

                    // loop until you find a character that is unique to the one you want to delete.
                    while (checkChar == deleteChar)
                    {
                        if (checkIndex >= 0)
                        {
                            checkIndex--;
                            if (checkIndex < 0)
                            {
                                break;
                            }
                            checkChar = result[checkIndex];
                            count++;
                        }
                        else break;
                    }

                    result = result.Remove(checkIndex + 1, count);
                }
            }

            return result;

        }

        public static string OldPhonePad(string input)
        {
            // check input must only have number, # or *
            if (Parsing.CanParsing(input))
            {
                // call variable
                string pattern = "(\\w)\\1*";

                // delete string after #
                string[] words = input.Split('#');
                string choose = words[0];

                // delete char by *
                string afterDelete = deleteIndex(choose);

                // separate input to group of number
                MatchCollection matches = Regex.Matches(afterDelete, pattern);
                string[] groups = matches.Cast<Match>().Select(match => match.Value).ToArray();

                string result = "";
                //parsing group of number to character
                foreach (string str in groups)
                {
                    result += Parsing.ParsingInput(str);
                }

                return result;
            }
            else
                throw new InvalidOperationException("Input must only have 0-9, * or #");

        }

        static void Main(string[] args)
        {
            // string str = "8 88777444666*664#";
            Console.Write("Enter a string - ");
            string input = Console.ReadLine();
            Console.WriteLine(OldPhonePad(input));
        }
    }
}