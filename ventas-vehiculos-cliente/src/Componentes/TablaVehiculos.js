import { Table, Button } from "reactstrap";

const data = [
  {
    "modelo": "Corolla",
    "marca": "Toyota",
    "idTipoVehiculo": 2,
    "unidades": 5,
    "precio": 2000000,
    "fechaIngreso": "2023-08-24T13:10:20.44",
    "nombreVendedor": "Karla",
    "habilitado": true
  },
  {
    "modelo": "Sentra",
    "marca": "Nissan",
    "idTipoVehiculo": 2,
    "unidades": 10,
    "precio": 1500000,
    "fechaIngreso": "2023-08-24T19:49:17.787",
    "nombreVendedor": "Andrey",
    "habilitado": false
  }
]



const TablaVehiculos = () => {
  return (
    <Table striped responsive>
      <thead>
        <tr>
          <th>Modelo</th>
          <th>Marca</th>
          <th>Tipo</th>
          <th>Unidades</th>
          <th>Precio</th>
          <th>Fecha Ingreso</th>
          <th>Vendedor</th>
          <th></th>
        </tr>
      </thead>
      <tbody>
        {
          (data.length < 1) ? (
            <tr>
              <td colSpan="4" className="text-center">Sin registros</td>
            </tr>) : (
            data.map((vehiculo) => (
              <tr key={vehiculo.modelo + vehiculo.marca + vehiculo.idTipoVehiculo}>
                <td>{vehiculo.modelo}</td>
                <td>{vehiculo.marca}</td>
                <td>{vehiculo.idTipoVehiculo}</td>
                <td>{vehiculo.unidades}</td>
                <td>{vehiculo.precio}</td>
                <td>{vehiculo.fechaIngreso}</td>
                <td>{vehiculo.nombreVendedor}</td>
                <td>
                  <Button size="sm" color="primary" className="me-2">
                    Editar
                  </Button>
                  <Button size="sm" color="danger">
                    Eliminar
                  </Button>
                </td>
              </tr>
            ))
          )
        }
      </tbody>
    </Table>
  );
}

export default TablaVehiculos;