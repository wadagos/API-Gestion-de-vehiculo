using Microsoft.EntityFrameworkCore;
using Gestion_de_Vehiculo;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.OpenApi.Models;

namespace Gestion_de_Vehiculo.Controllers.Data.Startup
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<VehiculoContexto>(options =>
                options.UseSqlServer(configuration.GetConnectionString("conexionDB")));
        }

    }
    

}
