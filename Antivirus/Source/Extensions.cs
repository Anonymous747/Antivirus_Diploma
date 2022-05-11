namespace Antivirus.Source
{
    static class Extensions
    {
        static public bool isEmty(this string[] strings) {
            if (strings.Length == 0) {
                return true;
            }

            return false;
        }

        static public string GetFileName(this string s)
        {
            var array = s.Split('\\');
            return array[array.Length - 1];
        }
    }
}
