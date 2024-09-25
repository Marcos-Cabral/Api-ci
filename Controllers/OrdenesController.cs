using Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class Orden
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public DateTime Fecha { get; set; }
    }

    [ApiController]
    [Route("[controller]")]
    public class OrdenesController : ControllerBase
    {
        public IOrdenesService _ordenesService { get; set; }
        public OrdenesController(IOrdenesService ordenesService)
        {
            _ordenesService = ordenesService;
        }

        [HttpGet(Name = "Ordenes")]
        public List<Orden> Get()
        {
            return _ordenesService.GetAll();
        }
    }
}
