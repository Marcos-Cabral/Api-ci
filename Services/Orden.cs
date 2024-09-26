namespace Services
{
    public class Orden
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public double Precio { get; set; }
        public DateTime Fecha { get; set; }

        public Orden()
        {
        }

        public Orden(int id, string descripcion, double precio, DateTime fecha)
        {
            Id = id;
            Descripcion = descripcion;
            Precio = precio;
            Fecha = fecha;
        }
    }
}
