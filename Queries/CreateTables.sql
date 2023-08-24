use VentaVehiculos;


Create table TipoVehiculo (
	IdTipoVehiculo int identity(1,1),
	Descripcion varchar(30),

	primary key(IdTipoVehiculo)
);

Create table TipoVehiculo (
	IdTipoVehiculo int identity(1,1),
	Descripcion varchar(30),

	primary key(IdTipoVehiculo)
);

insert into TipoVehiculo(Descripcion) values 
('SUV'), ('Sedán'), ('4x4'), ('Autobús'), ('Pickup');

Create table Vehiculo  (
	Modelo varchar(20),
	Marca varchar(20),
	IdTipoVehiculo int,

	Unidades int not null,
	Precio decimal(19,4) not null,
	FechaIngreso datetime not null,
	NombreVendedor varchar(30) not null,
	Habilitado bit not null

	primary key(Modelo, Marca, IdTipoVehiculo),
	foreign key (IdTipoVehiculo) references TipoVehiculo(IdTipoVehiculo)
);