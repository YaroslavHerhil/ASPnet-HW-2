using ASPnet_HW_2.Abstract;
using ASPnet_HW_2.Model;
using System.Text;
using System.Xml.Linq;

namespace ASPnet_HW_2.Services
{
    public class ShapesService : IShapesService
    {
        private List<Shape> _shapes;

        public ShapesService() 
        {
            _shapes = new List<Shape>();
        }

        public void AddShape(Shape shape) =>
            _shapes.Add(shape);
        public List<Shape> GetShapes() =>
            _shapes;


        public void WriteAllToFile(string path)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                foreach(Shape shape in _shapes)
                {
                    sw.Write(shape);
                }
            }
        }


        public void ReadAllFromFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                while(!sr.EndOfStream) { 
                    var shape = new Shape();
                    shape.Name = ReadUntil(sr, "/");
                    shape.Visual = ReadUntil(sr, "/");
                    _shapes.Add(shape);
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
