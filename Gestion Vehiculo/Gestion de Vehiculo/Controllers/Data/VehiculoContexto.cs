using Microsoft.EntityFrameworkCore;

namespace Gestion_de_Vehiculo.Controllers.Data
{
    public class VehiculoContexto : DbContext
    {
        public VehiculoContexto(DbContextOptions<VehiculoContexto> options)
        : base(options)
        {
        }

        public DbSet<Vehiculos> Vehiculos { get; set; }
    }
}
