using Services.Services;
using Services;

namespace Api.Tests
{
    [TestFixture]
    public class OrdenesServiceTests
    {
        private OrdenesService _ordenesService;

        [SetUp]
        public void Setup()
        {
            _ordenesService = new OrdenesService();
        }

        [Test]
        [Description("Prueba que el GetAll de Orden devuelva una lista de objetos Orden, que no sea nula y contenga al menos un elemento.")]
        public void OrdenGetAll()
        {
            List<Orden> result = _ordenesService.GetAll(); 
            Assert.IsNotNull(result, "El resultado no debe ser nulo.");
            Assert.IsInstanceOf<List<Orden>>(result, "El resultado debe ser una lista de Orden.");
            Assert.IsTrue(result.Count > 0, "La lista debe contener al menos un elemento.");
        }

        [Test]
        [Description("Prueba que GetById de Orden devuelva un objeto Orden existente en la lista.")]
        public void OrdenGetByIdExists()
        {
            Orden orden = _ordenesService.GetById(_ordenesService.GetAll().First().Id);

            Assert.IsNotNull(orden, "El resultado no debe ser nulo.");
            Assert.IsInstanceOf<Orden>(orden, "El resultado debe ser una lista de Orden.");
        }

        [Test]
        [Description("Prueba que GetById de Orden devuelva nulo cuando se le pasa un ID que no existe.")]
        public void OrdenGetByIdNotExists()
        {
            Orden orden = _ordenesService.GetById(99999999);
            Assert.IsNull(orden, "El resultado debe ser nulo.");
        }
    }
}