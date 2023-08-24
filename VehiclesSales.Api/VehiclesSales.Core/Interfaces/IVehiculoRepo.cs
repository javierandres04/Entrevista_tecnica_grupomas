using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesSales.Core.DTOs;
using VehiclesSales.Core.Entidades;

namespace VehiclesSales.Core.Interfaces
{
    public interface IVehiculoRepo
    {
        public Task<IEnumerable<Vehiculo>> Get();
        public Task<Vehiculo> Get(string modelo, string marca, int idTipo);
        public Task<bool> Post(Vehiculo vehiculo);
        public Task<bool> Put(Vehiculo vehiculoViejo, Vehiculo vehiculoNuevo);
        public Task<bool> Delete(Vehiculo vehiculo);

    }
}
