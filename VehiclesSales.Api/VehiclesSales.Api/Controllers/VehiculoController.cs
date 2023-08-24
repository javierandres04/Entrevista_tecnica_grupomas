using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VehiclesSales.Core.DTOs;
using VehiclesSales.Core.Entidades;
using VehiclesSales.Core.Interfaces;

namespace VehiclesSales.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehiculoController : ControllerBase
    {
        private readonly IVehiculoRepo _vehiculoRepo;
        private readonly IMapper _mapper;

        public VehiculoController(IVehiculoRepo vehiculoRepo, IMapper mapper)
        {
            _vehiculoRepo = vehiculoRepo;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("Obtener")]
        public async Task<IActionResult> Get()
        {
            var vehiculos = await _vehiculoRepo.Get();
            var vehiculosDto = _mapper.Map < IEnumerable<VehiculoDTO>>(vehiculos);
            return Ok(vehiculosDto);
        }

        [HttpPost]
        [Route("Agregar")]
        public async Task<IActionResult> Post([FromBody]VehiculoDTO vehiculo)
        {
            var vehiculoDto = _mapper.Map<Vehiculo>(vehiculo);
            var agregado = await _vehiculoRepo.Post(vehiculoDto);

            if (agregado)
                   return Ok(agregado);
            else 
                return BadRequest("No se pudo agregar el vehiculo");
        }


        [HttpPut]
        [Route("Editar")]
        public async Task<IActionResult> Put([FromBody]VehiculoDTO vehiculo)
        {
            var vehiculoViejo = await _vehiculoRepo.Get(vehiculo.Modelo, vehiculo.Marca, vehiculo.IdTipoVehiculo);
            if (vehiculoViejo == null)
                return BadRequest("El vehiculo no existe");

            var vehiculoNuevo = _mapper.Map<Vehiculo>(vehiculo);

            var modificado = await _vehiculoRepo.Put(vehiculoViejo, vehiculoNuevo);

            if (modificado)
                return Ok(modificado);
            else
                return BadRequest("No se pudo modificar el vehiculo");
        }

        [HttpPut]
        [Route("Eliminar")]
        public async Task<IActionResult> Delete(string modelo, string marca, int idTipo)
        {
            var vehiculoEliminar = await _vehiculoRepo.Get(modelo, marca, idTipo);
            if (vehiculoEliminar == null)
                return BadRequest("El vehiculo no existe");

            var eliminado = await _vehiculoRepo.Delete(vehiculoEliminar);

            if (eliminado)
                return Ok(eliminado);
            else
                return BadRequest("No se pudo eliminar el vehiculo");
        }

    }

        
    
}