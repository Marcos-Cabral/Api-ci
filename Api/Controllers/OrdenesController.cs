using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Services;

namespace Api.Controllers
{

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

        [HttpGet(Name = "OrdenById")]
        public Orden GetById(int id)
        {
            return _ordenesService.GetById(id);
        }
    }
}
