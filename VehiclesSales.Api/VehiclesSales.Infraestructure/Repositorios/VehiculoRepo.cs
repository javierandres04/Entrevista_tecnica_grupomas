using Microsoft.EntityFrameworkCore;
using VehiclesSales.Core.Entidades;
using VehiclesSales.Core.Interfaces;
using VehiclesSales.Infraestructure.Data;

namespace VehiclesSales.Infraestructure.Repositorios
{
    public class VehiculoRepo : IVehiculoRepo
    {
        private readonly VentaVehiculosContext _dbContext;

        public VehiculoRepo(VentaVehiculosContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Vehiculo>> Get()
        {
            return await _dbContext.Vehiculos.ToListAsync();
        }

        public async Task<Vehiculo> Get(string modelo, string marca, int idTipo)
        {
            return await _dbContext.Vehiculos.FindAsync(modelo, marca, idTipo);
        }
        public async Task<bool> Post(Vehiculo vehiculo)
        {
            var agregado = await _dbContext.AddAsync(vehiculo);
            if (agregado != null && agregado.State == EntityState.Added)
            {
                await _dbContext.SaveChangesAsync();
                return true;
            } else
            {
                return false; 
            }
        }

        public async Task<bool> Put(Vehiculo vehiculoViejo, Vehiculo vehiculoNuevo)
        {

            vehiculoViejo.Unidades = vehiculoNuevo.Unidades;
            vehiculoViejo.Precio = vehiculoNuevo.Precio;
            vehiculoViejo.FechaIngreso = vehiculoNuevo.FechaIngreso;
            vehiculoViejo.NombreVendedor = vehiculoNuevo.NombreVendedor;
            vehiculoViejo.Habilitado = vehiculoNuevo.Habilitado;

            var modificado = _dbContext.Update(vehiculoViejo);
            if (modificado != null && modificado.State == EntityState.Modified)
            {
                await _dbContext.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<bool> Delete(Vehiculo vehiculo)
        {
            vehiculo.Habilitado= false;
            var eliminado = _dbContext.Update(vehiculo);
            if (eliminado != null && eliminado.State == EntityState.Modified)
            {
                await _dbContext.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
