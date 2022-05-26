namespace Antivirus.Source
{
    static class Constants
    {
        public const string kInfectedString = "Infected!";
        public const string kCleanString = "Clean!";

        public const int kHomeScreenIndex = 0;
        public const int kFileScanningScreenIndex = 1;
        public const int kQuarantineScreenIndex = 2;
        public const int kSystemInformationScreenIndex = 3;
        public const int kUpdatesScreenIndex= 4;
        public const int kAboutAppScreenIndex = 5;

        public const int kMaximumLoaderValue = 1000;
    }

    static class Sections
    {
        public const string RESOURCES = ".rsrc";
        public const string IMPORTS = ".idata";
    }
}
