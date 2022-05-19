using Antivirus.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antivirus.Repository
{
    public class FileArchivator
    {
        private List<InfectedFile> malvares;

        public FileArchivator(List<InfectedFile> infectedFiles)
        {
            this.malvares = infectedFiles;
        }

        public void ArchivateMalvares()
        {
            foreach (var infectedFile in malvares)
            {
                var filePath = infectedFile.Path;
                var fileName = filePath.Split('\\').Last();
                var pathToFileLocation = filePath.Replace(fileName, "");
                var pathToZip = filePath.Replace(".txt", ".zip");
                var temporaryFolder = $"{pathToFileLocation}virusesFolder";

                // Get of rid remained zip files
                if (File.Exists(pathToZip))
                {
                    File.Delete(pathToZip);
                }

                // Directory cleaning
                if (Directory.Exists(temporaryFolder))
                {
                    string[] fileNamesInFolder = Directory.GetFiles(temporaryFolder);
                    foreach (string name in fileNamesInFolder)
                    {
                        File.Delete(name);
                    }
                    Directory.Delete(temporaryFolder);
                }

                Directory.CreateDirectory(temporaryFolder);
                File.Copy(filePath, $"{temporaryFolder}\\{fileName}");
                ZipFile.CreateFromDirectory(temporaryFolder, pathToZip);
            }
        }
    }
}
