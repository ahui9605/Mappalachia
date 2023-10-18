using System;
using System.Diagnostics;
using System.IO;

namespace Mappalachia
{
    class JPEG2BA2
    {
        // Removed static readonly fields for MapJPEG and directoryPath
        public static void ProcessMapFile(string mapJPEGPath)
        {
            string directoryPath = Path.GetDirectoryName(mapJPEGPath);

            string mapDdsLooseFile = Path.Combine(directoryPath, "BA2out", "textures", "interface", "pip-boy");
            string ba2ArchiveRootPath = Path.Combine(directoryPath, "BA2out");
            string ba2ArchiveOutputPath = Path.Combine(directoryPath, "BA2out", $"{Path.GetFileNameWithoutExtension(mapJPEGPath)}.ba2");
            string texconvPath = @"tools\texconv.exe";
            string archiveExePath = @"tools\Archive2\Archive2.exe";

            ConvertJpgeToDds(mapJPEGPath, mapDdsLooseFile, texconvPath);
            Ba2ArchiveGenerate(ba2ArchiveRootPath, ba2ArchiveOutputPath, archiveExePath);
            CleanUp(directoryPath, mapJPEGPath);
        }

        static void ConvertJpgeToDds(string mapJPEGPath, string mapDdsLooseFile, string texconvPath)
        {
            if (!Directory.Exists(mapDdsLooseFile))
            {
                Directory.CreateDirectory(mapDdsLooseFile);
            }

            string args = $"-f DXT1 -o \"{mapDdsLooseFile}\" \"{mapJPEGPath}\"";
            ExecuteCommand(texconvPath, args);

            string originalDdsPath = Path.Combine(mapDdsLooseFile, Path.GetFileNameWithoutExtension(mapJPEGPath) + ".dds");
            string newDdsPath = Path.Combine(mapDdsLooseFile, "papermap_city_d.dds");
            File.Move(originalDdsPath, newDdsPath);
        }

        static void Ba2ArchiveGenerate(string ba2ArchiveRootPath, string ba2ArchiveOutputPath, string archiveExePath)
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
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                };

                using Process process = Process.Start(processStartInfo);
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                process.WaitForExit();

                if (!string.IsNullOrWhiteSpace(output) || !string.IsNullOrWhiteSpace(error))
                {
                    using StreamWriter sw = new StreamWriter("errorLog.txt", true); // true to append data
                    sw.WriteLine($"Command: {command} {arguments}");
                    sw.WriteLine("Output: " + output);
                    sw.WriteLine("Error: " + error);
                    sw.WriteLine("Exit Code: " + process.ExitCode);
                    sw.WriteLine("-----------");
                }
            }
            catch (Exception ex)
            {
                using StreamWriter sw = new StreamWriter("errorLog.txt", true); // true to append data
                sw.WriteLine($"Exception for command: {command} {arguments}");
                sw.WriteLine("Exception Message: " + ex.Message);
                sw.WriteLine("-----------");
            }
        }

        static void CleanUp(string directoryPath, string mapJPEGPath)
        {
            string texturesPath = Path.Combine(directoryPath, "Ba2out", "textures");

            if (Directory.Exists(texturesPath))
            {
                Directory.Delete(texturesPath, true);
            }

            if (File.Exists(mapJPEGPath))
            {
                File.Delete(mapJPEGPath);
            }
        }
    }
}