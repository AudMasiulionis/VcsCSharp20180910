namespace Lesson18_FilesAndDataStructures
{
    public class NileData
    {
        public int Year { get; set; }
        public double Flood { get; set; }

        public string ToCsvString()
        {
            return $"{Year},{Flood}";
        }
    }
}
