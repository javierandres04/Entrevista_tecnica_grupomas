using System;
using System.Collections.Generic;

namespace VehiclesSales.Core.Entidades
{
    public partial class TipoVehiculo
    {
        public TipoVehiculo()
        {
            Vehiculos = new HashSet<Vehiculo>();
        }

        public int IdTipoVehiculo { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
