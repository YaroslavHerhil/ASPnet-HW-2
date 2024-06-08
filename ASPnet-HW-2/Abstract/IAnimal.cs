namespace ASPnet_HW_2.Abstract
{
    public interface IAnimal
    {
        public string Name { get; set; }

        public string Sound { get; set; }

        public string ToPrettyString();
        public void WriteToFile(string path);
        public void ReadFromFile(string path);
        public void WriteNameToFile(string path);
        public void WriteSoundToFile(string path);
    }
}
