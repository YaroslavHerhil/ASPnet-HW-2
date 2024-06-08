using ASPnet_HW_2.Abstract;
using ASPnet_HW_2.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPnet_HW_2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IAnimalService AnimalService;
        public IShapesService ShapesService;
        public IndexModel(ILogger<IndexModel> logger, IAnimalService animalService, IShapesService shapesService)
        {
            _logger = logger;
            AnimalService = animalService;
            ShapesService = shapesService;
        }

        public void OnGet()
        {
            //    AnimalService.AddAnimal(new Animal { Name = "Ani", Sound = "mal" });
            //    AnimalService.WriteAllToFile("Animals.animal");
            AnimalService.ReadAllFromFile("Animals.animal");
            //ShapesService.AddShape(new Shape { Name = "Triangle", Visual = "🔺" });
            //ShapesService.WriteAllToFile("Shape.ddl");
            ShapesService.ReadAllFromFile("Shape.ddl");
        }
    }
}
