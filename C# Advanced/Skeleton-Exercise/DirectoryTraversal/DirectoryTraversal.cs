namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            //C:\Users\marty\OneDrive\Documents\ИТ
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            Dictionary<string, Dictionary<string, double>> filesByExtension = new();

            string[] files =  Directory.GetFiles(inputFolderPath);

            foreach (var file in files)
            {
                FileInfo info = new  FileInfo(file);

                string extension = info.Extension;
                string name = info.Name;
                double size = info.Length / 1024.0;

                if (!filesByExtension.ContainsKey(extension))
                {
                    filesByExtension.Add(extension, new Dictionary<string, double>());
                }

                filesByExtension[extension].Add(name, size);
            }

            StringBuilder sb = new StringBuilder();

            foreach (var extension in filesByExtension) 
            {
                sb.AppendLine($"{extension.Key}");

                foreach (var file in extension.Value)
                {
                    sb.AppendLine($"--{file.Key} - {file.Value:f3}kb");
                }
            
            }
            ;
            return sb.ToString();

        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string desktopDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string combined = desktopDirectory + reportFileName;

            File.WriteAllText(combined, textContent);
        }
    }
}
