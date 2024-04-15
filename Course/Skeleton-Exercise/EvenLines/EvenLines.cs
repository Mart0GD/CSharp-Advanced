namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StreamReader reader = new StreamReader(inputFilePath);
            StringBuilder sb = new StringBuilder();

            int lineNumber = 0;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                if (lineNumber % 2 != 0)
                {
                    lineNumber++;
                    continue;
                }

                string replacedSymbols = ReplaceSymbols(line);
                sb.AppendLine(ReverseWords(replacedSymbols));

                lineNumber++;
            }


            return sb.ToString();
        }

        private static string ReplaceSymbols(string line)
        {
            StringBuilder sb = new StringBuilder(line);

            char[] charsToReplace = new char[] { '-', ',', '.', '!', '?' };

            foreach (var _char in charsToReplace)
            {
                sb.Replace(_char, '@');
            }

            return sb.ToString();
        }

        private static string ReverseWords(string v)
        {
            string[] reversed = v.Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();

            return string.Join(" ", reversed);
        }
    }
}
