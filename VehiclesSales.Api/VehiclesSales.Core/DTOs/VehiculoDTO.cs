namespace VehiclesSales.Core.DTOs
{
    public partial class VehiculoDTO
    {
        public string Modelo { get; set; } = null!;
        public string Marca { get; set; } = null!;
        public int IdTipoVehiculo { get; set; }
        public int Unidades { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string NombreVendedor { get; set; } = null!;
        public bool Habilitado { get; set; }

    }
}

