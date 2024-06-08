using ASPnet_HW_2.Model;

namespace ASPnet_HW_2.Abstract
{
    public interface IAnimalService
    {
        public void WriteAllToFile(string path);
        public void ReadAllFromFile(string path);
        public List<Animal> Animals();
        public void AddAnimal(Animal animal);


    }
}
