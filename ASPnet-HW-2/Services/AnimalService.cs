using ASPnet_HW_2.Abstract;
using ASPnet_HW_2.Model;
using System.Text;
using System.Xml.Linq;

namespace ASPnet_HW_2.Services
{
    public class AnimalService : IAnimalService
    {
        private List<Animal> _animals;

        public AnimalService() 
        {
            _animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal) =>
            _animals.Add(animal);
        public List<Animal> Animals() =>
            _animals;


        public void WriteAllToFile(string path)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                foreach(Animal animal in _animals)
                {
                    sw.Write(animal);
                }
            }
        }


        public void ReadAllFromFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                while(!sr.EndOfStream) { 
                    var animal = new Animal();
                    animal.Name = ReadUntil(sr, "/");
                    animal.Sound = ReadUntil(sr, "/");
                    _animals.Add(animal);
                }
            }

        }


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

    }
}
