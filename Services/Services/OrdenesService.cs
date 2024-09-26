using GenFu;

namespace Services.Services
{
    public class OrdenesService : IOrdenesService
    {
        public List<Orden> _ordenes { get; set; }

        public OrdenesService()
        {
            GenFu.GenFu.Configure<Orden>()
              .Fill(ei => ei.Id, () => A.Random.Next(1, 100))
              .Fill(ei => ei.Descripcion).AsCanadianProvince()
              .Fill(ei => ei.Precio, () => A.Random.NextDouble() * 100);

            _ordenes = A.ListOf<Orden>(10);
        }

        public List<Orden> GetAll()
        {
            return _ordenes;
        }

        public Orden GetById(int id)
        {
            return _ordenes.FirstOrDefault(e => e.Id == id);
        }
    }
}
