namespace LineNumbers
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string[] lines = File.ReadLines(inputFilePath).ToArray();

            StringBuilder sb = new();

            for (int i = 0; i < lines.Length; i++)
            {
                int letters = lines[i].Count(x => Char.IsLetter(x));
                int punctuation = lines[i].Count(x => Char.IsPunctuation(x));

                sb.AppendLine($"Line {i + 1}: {lines[i]} ({letters})({punctuation})");
            }

            File.WriteAllText(outputFilePath, sb.ToString());
        }
    }
}
