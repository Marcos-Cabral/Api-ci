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
    }
}