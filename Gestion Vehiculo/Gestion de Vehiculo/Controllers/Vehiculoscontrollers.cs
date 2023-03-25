using Gestion_de_Vehiculo.Controllers.Data;
using Microsoft.AspNetCore.Mvc;

namespace Gestion_de_Vehiculo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Vehiculoscontrollers : Controller
    {
        private static List<Vehiculos> _vehiculos = new List<Vehiculos>();


       
        
        [HttpGet]
        public IEnumerable<Vehiculos> Get()
        {
            return _vehiculos;
        }

        [HttpGet("{Id}")]
        public ActionResult<Vehiculos> Get(string id)
        {
            var vehicle = _vehiculos.FirstOrDefault(v => v.Id == id);
            if (vehicle == null)
            {
                return NotFound();
            }
            return vehicle;
        }

        [HttpPost]
        public ActionResult<Vehiculos> Post(Vehiculos Vehiculos)
        {
            Vehiculos.Id = Guid.NewGuid().ToString();
            _vehiculos.Add(Vehiculos);
            return CreatedAtAction(nameof(Get), new { id = Vehiculos.Id }, Vehiculos);
        }

        [HttpPut("{Id}")]
        public IActionResult Put(string id, Vehiculos vehicle, Vehiculos vehiculos)
        {
            var index = _vehiculos.FindIndex(v => v.Id == id);
            if (index == -1)
            {
                return NotFound();
            }
            _vehiculos[index] = vehiculos;
            return NoContent();
        }

        [HttpDelete("{Id}")]
        public ActionResult<Vehiculos> Delete(string id)
        {
            var Vehiculos = _vehiculos.FirstOrDefault(v => v.Id == id);
            if (Vehiculos == null)
            {
                return NotFound();
            }
            _vehiculos.Remove(Vehiculos);
            return Vehiculos;
        }
    }
}
