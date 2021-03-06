namespace Antivirus.Model
{
    public class InfectedFile {
        public string Path { get; private set; }
        public string VirusType { get; private set; }

        public InfectedFile(string path, string virusType) {
            this.Path = path;
            this.VirusType = virusType;
        }
    }
}
