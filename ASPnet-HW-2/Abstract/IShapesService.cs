using ASPnet_HW_2.Model;

namespace ASPnet_HW_2.Abstract
{
    public interface IShapesService
    {
        public void WriteAllToFile(string path);
        public void ReadAllFromFile(string path);
        public List<Shape> GetShapes();
        public void AddShape(Shape shape);


    }
}
