namespace Antivirus.Model
{
    public struct EXTENDED_IMAGE_SECTION_HEADER
    {
        /// <summary>
        /// Image Section headers. Number of sections is in the file header.
        /// </summary>
        public IMAGE_SECTION_HEADER sectionHeader;
        /// <summary>
        /// The level of section complexity
        /// </summary>
        public float entropy;
    }
}
