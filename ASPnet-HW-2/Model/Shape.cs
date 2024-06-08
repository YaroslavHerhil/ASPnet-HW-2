using ASPnet_HW_2.Abstract;
using System.Drawing;

namespace ASPnet_HW_2.Model
{
    public class Shape : IShape
    {
        public string Name { get; set; }
        public string Visual { get; set; }

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
                Visual = ReadUntil(sr, "/");
            }
        }

        public void WriteNameToFile(string path)
        {
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.Write(Name);
            }
        }

        public void WriteVisualToFile(string path)
        {
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.Write(Visual);
            }
        }

        public void WriteToFile(string path)
        {
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.Write(this);
            }
        }
        public  string ToPrettyString()
        {
            return $"{Name} looks like {Visual}!";
        }
        public override string ToString()
        {
            return $"{Name}/{Visual}/";
        }

    }
}
