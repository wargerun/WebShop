using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            const string AssemblyInfoFileName = "AssemblyInfo.cs";
            string path = @"C:\Users\Tim\Documents\GitHub\TimUtils\";
            string[] excludeDirectories = {"packages", ".git", ".nuget", "build", "lib", "resources", "scripts", ".idea", ".vs"};
            string[] directories = Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly);
            string[] filteredDirectories =
                directories.Where(d => !excludeDirectories.Contains(new DirectoryInfo(d).Name)).ToArray();
            int updatedFilesCount = 0;

            foreach (string dir in filteredDirectories)
            {
                string[] assemblyInfoFiles = Directory.GetFiles(dir, AssemblyInfoFileName, SearchOption.AllDirectories);
                foreach (string filePath in assemblyInfoFiles)
                    updatedFilesCount += HandleFile(filePath);
            }

            
            Console.WriteLine($"Assemblies processed: {updatedFilesCount}");
        }

        private static int HandleFile(string path)
        {
            string fileContent = File.ReadAllText(path);
            string newFileContent = fileContent;

            Regex assemblyVersionRegex = new Regex(@"\n\[assembly: AssemblyVersion\(\""(?<version>.+)\""\)\]", RegexOptions.Compiled);
            if (assemblyVersionRegex.IsMatch(fileContent))
            {
                Match m = assemblyVersionRegex.Match(fileContent);
                string ver = m.Groups["version"].Value;
                if (!ver.Contains("*"))
                {
                    Version v = new Version(ver);
                    Version newVer = new Version(v.Major, v.Minor, v.Build, v.Revision + 1);
                    newFileContent = assemblyVersionRegex.Replace(newFileContent, string.Format("\n[assembly: AssemblyVersion(\"{0}\")]", newVer.ToString()));
                }
            }

            Regex assemblyFileVersionRegex = new Regex(@"\n\[assembly: AssemblyFileVersion\(\""(?<version>.+)\""\)\]", RegexOptions.Compiled);
            if (assemblyFileVersionRegex.IsMatch(fileContent))
            {
                Match m = assemblyFileVersionRegex.Match(fileContent);
                string ver = m.Groups["version"].Value;
                if (!ver.Contains("*"))
                {
                    Version v = new Version(ver);
                    Version newVer = new Version(v.Major, v.Minor, v.Build, v.Revision + 1);
                    newFileContent = assemblyFileVersionRegex.Replace(newFileContent, string.Format("\n[assembly: AssemblyFileVersion(\"{0}\")]", newVer.ToString()));
                }
            }

            if (newFileContent != fileContent)
            {
                //File.WriteAllText(path, newFileContent, Encoding.UTF8);
                return 1;
            }

            return 0;
        }
    }
}