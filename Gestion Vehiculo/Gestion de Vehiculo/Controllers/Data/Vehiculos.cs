namespace Gestion_de_Vehiculo.Controllers.Data
{
    public class Vehiculos
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public decimal Precio { get; set; }
        public string Estatus { get; set; }
        public string Id { get; internal set; }
    }
}
