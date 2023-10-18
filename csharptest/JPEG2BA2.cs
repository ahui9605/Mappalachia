using System;
using System.Diagnostics;
using System.IO;

namespace Mappalachia
{
    public class JPEG2BA2
    {
        // Removed static readonly fields for MapJPEG and CurrentDirectory

        public static void ProcessMapFile(string mapJPEGPath, string currentDirectory)
        {
            string mapDdsLooseFile = Path.Combine(currentDirectory, "BA2out", "textures", "interface", "pip-boy");
            string ba2ArchiveRootPath = Path.Combine(currentDirectory, "Ba2out");
            string ba2ArchiveOutputPath = Path.Combine(currentDirectory, "Ba2out", "archive.ba2");
            string texconvPath = Path.Combine(currentDirectory, "tools", "texconv.exe");
            string archiveExePath = Path.Combine(currentDirectory, "tools", "Archive2", "Archive2.exe");

            ConvertJpgToDds(mapJPEGPath, mapDdsLooseFile, texconvPath);
            CreateBa2Archive(ba2ArchiveRootPath, ba2ArchiveOutputPath, archiveExePath);
            DeleteTexturesDirectory(currentDirectory);
        }

        static void ConvertJpgToDds(string mapJPEGPath, string mapDdsLooseFile, string texconvPath)
        {
            if (!Directory.Exists(mapDdsLooseFile))
            {
                Directory.CreateDirectory(mapDdsLooseFile);
            }

            string args = $"-f DXT1 -o \"{mapDdsLooseFile}\" \"{mapJPEGPath}\"";

            ExecuteCommand(texconvPath, args);
        }

        static void CreateBa2Archive(string ba2ArchiveRootPath, string ba2ArchiveOutputPath, string archiveExePath)
        {
            string arguments = $"\"{ba2ArchiveRootPath}\" -create=\"{ba2ArchiveOutputPath}\" -root=\"{ba2ArchiveRootPath}\" -format=DDS";

            ExecuteCommand(archiveExePath, arguments);
        }

        static void ExecuteCommand(string command, string arguments)
        {
            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = command,
                    Arguments = arguments,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                };

                using (Process process = Process.Start(processStartInfo))
                {
                    Console.WriteLine(process.StandardOutput.ReadToEnd());
                    Console.WriteLine(process.StandardError.ReadToEnd());

                    process.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        static void DeleteTexturesDirectory(string currentDirectory)
        {
            string texturesPath = Path.Combine(currentDirectory, "Ba2out", "textures");

            try
            {
                // Check if directory exists
                if (Directory.Exists(texturesPath))
                {
                    // Delete directory and all its contents
                    Directory.Delete(texturesPath, true);
                    Console.WriteLine("Textures directory deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Textures directory does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while deleting the textures directory: " + ex.Message);
            }
        }
    }
}
// public class Program // 注意: 类名应该是 Program 而非 Porgram
// {
//     public static void Main()
//     {
//         string mapJPEGPath = @"C:\Users\leoli\Desktop\csharptest\papermap_city_d.jpeg";
//         string directoryPath = Path.GetDirectoryName(mapJPEGPath);

//         try
//         {
//             Map2Ba2.ProcessMapFile(mapJPEGPath, directoryPath); // 使用 directoryPath 替代 currentDirectory
//             Console.WriteLine("Process completed successfully.");
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine("An error occurred: " + ex.Message);
//         }
//     }
// }
