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
        public void GetAll_Returns_ListOfOrdenes()
        {
            List<Orden> result = _ordenesService.GetAll(); 
            Assert.IsNotNull(result, "El resultado no debe ser nulo.");
            Assert.IsInstanceOf<List<Orden>>(result, "El resultado debe ser una lista de Orden.");
            Assert.IsTrue(result.Count > 0, "La lista debe contener al menos un elemento.");
        }

        [Test]
        public void GetByIdExists()
        {
            Orden orden = _ordenesService.GetById(_ordenesService.GetAll().First().Id);

            Assert.IsNotNull(orden, "El resultado no debe ser nulo.");
            Assert.IsInstanceOf<Orden>(orden, "El resultado debe ser una lista de Orden.");
        }

        [Test]
        public void GetByIdNotExists()
        {
            Orden orden = _ordenesService.GetById(99999999);
            Assert.IsNull(orden, "El resultado debe ser nulo.");
        }
    }
}