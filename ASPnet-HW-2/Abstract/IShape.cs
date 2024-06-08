namespace ASPnet_HW_2.Abstract
{
    public interface IShape
    {
        public string Name { get; set; }
        public string Visual { get; set; }

        public void WriteToFile(string path);
        public void ReadFromFile(string path);
        public void WriteNameToFile(string path);
        public void WriteVisualToFile(string path);
    }
}
