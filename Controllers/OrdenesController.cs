using GenFu;
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
        //public List<Orden> _ordenes { get; set; }

        public OrdenesController()
        {
            GenFu.GenFu.Configure<Orden>()
           .Fill(ei => ei.Id, () => A.Random.Next(1, 100))
           .Fill(ei => ei.Descripcion).AsCanadianProvince()
           .Fill(ei => ei.Precio, () => A.Random.NextDouble() * 100);

            _ordenes = A.ListOf<Orden>(10);  
        }

        [HttpGet(Name = "Ordenes")]
        public List<Orden> Get()
        {
            return _ordenes;
        }
    }
}
