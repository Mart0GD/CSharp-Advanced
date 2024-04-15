namespace ZipAndExtract
{
    using System;
    using System.IO;
    using System.IO.Compression;
    using System.Linq;

    public class ZipAndExtract
    {
        static void Main()
        {
            Console.WriteLine("Files to zip (divide diffrent files with \", \")");
            string[] inputFiles = @$"{Console.ReadLine()}".Split(", ",StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Zip file path name");
            string zipArchiveFile = @$"\..\..\archive.zip";
            //string extractedFile = 

            ZipFileToArchive(inputFiles, zipArchiveFile);

            ExtractFileFromArchive(zipArchiveFile);//, extractedFile);
        }

        public static void ZipFileToArchive(string[] inputFilePaths, string zipArchiveFilePath)
        {
            if (File.Exists(zipArchiveFilePath))
            {
                File.Delete(zipArchiveFilePath);
            }

            using ZipArchive archive = ZipFile.Open(zipArchiveFilePath, ZipArchiveMode.Create);

            foreach (var filePath in inputFilePaths)
            {
                archive.CreateEntryFromFile(filePath, Path.GetFileName(filePath));
            }
        }


        public static void ExtractFileFromArchive(string zipArchiveFilePath)
        {
            using ZipArchive archive = ZipFile.OpenRead(zipArchiveFilePath);

            Console.WriteLine("Please place input for folder to extract");

            string outputFilePath = @$"{Console.ReadLine()}";

            ZipFile.ExtractToDirectory(zipArchiveFilePath, outputFilePath, true);
        }
    }
}
// BABA






