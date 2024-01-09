namespace ParsingFunction
{
    public class Parsing
    {
        public static bool CanParsing(string str)
        {
            // must have # in sentence
            bool haveHash = false;

            foreach (char c in str)
            {
                // must only have 0-9, * or #
                if (!char.IsDigit(c))
                {
                    if (c != '*' && c != '#' && c != ' ')
                        return false;
                    else if (c == '#') haveHash = true;
                }
            }

            if (!haveHash)
                throw new InvalidOperationException("Input must have #");

            return haveHash;
        }

        public static string ParsingInput(string str)
        {
            // check type group of string
            if (str.Contains('1')) return ParsingOneToText(str);
            else if (str.Contains('2')) return ParsingTwoToText(str);
            else if (str.Contains('3')) return ParsingThreeToText(str);
            else if (str.Contains('4')) return ParsingFourToText(str);
            else if (str.Contains('5')) return ParsingFiveToText(str);
            else if (str.Contains('6')) return ParsingSixToText(str);
            else if (str.Contains('7')) return ParsingSevenToText(str);
            else if (str.Contains('8')) return ParsingEightToText(str);
            else if (str.Contains('9')) return ParsingNineToText(str);
            else if (str.Contains('0')) return ParsingZeroToText(str);
            else return "";
        }

        private static string ParsingOneToText(string str)
        {
            int len = str.Length % 3;
            switch (len)
            {
                case 0: return "(";
                case 1: return "&";
                case 2: return "'";
                default: return "";
            }
        }


        private static string ParsingTwoToText(string str)
        {
            int len = str.Length % 3;
            switch (len)
            {
                case 0: return "C";
                case 1: return "A";
                case 2: return "B";
                default: return "";
            }
        }

        private static string ParsingThreeToText(string str)
        {
            int len = str.Length % 3;
            switch (len)
            {
                case 0: return "F";
                case 1: return "D";
                case 2: return "E";
                default: return "";
            }
        }

        private static string ParsingFourToText(string str)
        {
            int len = str.Length % 3;
            switch (len)
            {
                case 0: return "I";
                case 1: return "G";
                case 2: return "H";
                default: return "";
            }
        }

        private static string ParsingFiveToText(string str)
        {
            int len = str.Length % 3;
            switch (len)
            {
                case 0: return "L";
                case 1: return "J";
                case 2: return "K";
                default: return "";
            }
        }

        private static string ParsingSixToText(string str)
        {
            int len = str.Length % 3;
            switch (len)
            {
                case 0: return "O";
                case 1: return "M";
                case 2: return "N";
                default: return "";
            }
        }

        private static string ParsingSevenToText(string str)
        {
            int len = str.Length % 4;
            switch (len)
            {
                case 0: return "S";
                case 1: return "P";
                case 2: return "Q";
                case 3: return "R";
                default: return "";
            }
        }

        private static string ParsingEightToText(string str)
        {
            int len = str.Length % 3;
            switch (len)
            {
                case 0: return "V";
                case 1: return "T";
                case 2: return "U";
                default: return "";
            }
        }

        private static string ParsingNineToText(string str)
        {
            int len = str.Length % 4;
            switch (len)
            {
                case 0: return "Z";
                case 1: return "W";
                case 2: return "X";
                case 3: return "Y";
                default: return "";
            }
        }

        private static string ParsingZeroToText(string str)
        {
            string result = "";
            int len = str.Length;
            for (int i = 0; i < len; ++i)
            {
                result += " ";
            }
            return result;
        }

    }

}