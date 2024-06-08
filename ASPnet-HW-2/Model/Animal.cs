using ASPnet_HW_2.Abstract;
using System.Drawing;

namespace ASPnet_HW_2.Model
{
    public class Animal : IAnimal
    {
        public string Name { get; set; }
        public string Sound { get; set; }

        private string ReadUntil(StreamReader sr, string separator)
        {
            string output = "";
            while (sr.Peek() >= 0)
            {
                string nextSymbol = ((char)sr.Read()).ToString();
                if (nextSymbol == separator)
                {
                    break;
                }
                output += nextSymbol;
            }
            return output;
        }

        public void ReadFromFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                Name = ReadUntil(sr, "/");
                Sound = ReadUntil(sr, "/");
            }
        }

        public void WriteNameToFile(string path = "animalNames")
        {
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.Write(Name);
            }
        }

        public void WriteSoundToFile(string path = "animalSounds")
        {
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.Write(Sound);
            }
        }

        public void WriteToFile(string path = "animals")
        {
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.Write(this);
            }
        }
        public  string ToPrettyString()
        {
            return $"{Name} says {Sound}!";
        }
        public override string ToString()
        {
            return $"{Name}/{Sound}/";
        }
    }
}
