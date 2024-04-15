namespace CopyDirectory
{
    using System;
    using System.IO;

    public class CopyDirectory
    {
        static void Main()
        {
            //C:\Users\marty\Downloads\Нова папка (8)
            //C:\Users\marty\Downloads\Нова папка (7)
            string inputPath =  @$"{Console.ReadLine()}";
            string outputPath = @$"{Console.ReadLine()}";

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            string[] files = Directory.GetFiles(inputPath);


            if (Directory.Exists(outputPath))
            {
                Directory.Delete(outputPath, true);
            }

            Directory.CreateDirectory(outputPath);


            foreach (var file in files)
            {
                FileInfo info = new FileInfo(file);

                string newDir = Path.Combine(outputPath, info.Name);


                using FileStream reader = new FileStream(inputPath, FileMode.Open);
                using FileStream writer = new FileStream(newDir, FileMode.Create);

                byte[] buffer = new byte[1024];

                while (reader.Position < reader.Length)
                {
                    reader.Read(buffer, 0, buffer.Length);
                    reader.Write(buffer, 0, buffer.Length);
                }

                //info.CopyTo(newDir);
            }
            

        }
    }
}
