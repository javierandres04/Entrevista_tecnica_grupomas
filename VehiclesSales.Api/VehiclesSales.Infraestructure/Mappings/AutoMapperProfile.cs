using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesSales.Core.DTOs;
using VehiclesSales.Core.Entidades;

namespace VehiclesSales.Infraestructure.Mappings
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<Vehiculo,  VehiculoDTO>().ReverseMap();
            CreateMap<TipoVehiculo, VehiculoDTO>().ReverseMap();

        }
    }
}
