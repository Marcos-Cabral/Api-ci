namespace Services.Services
{
    public interface IOrdenesService
    {
        List<Orden> GetAll();
        Orden GetById(int id);
    }
}
