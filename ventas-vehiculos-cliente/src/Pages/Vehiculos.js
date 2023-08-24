import { Button, Card, CardBody, CardHeader, Col, Container, Row } from "reactstrap";
import TablaVehiculos from "../Componentes/TablaVehiculos";
import { useEffect, useState } from "react";

const Vehiculos = () => {

  const [vehiculos, setVehiculos] = useState([]);


  const recuperarVehiculos = async () => {

    const url = "api/Vehiculo/Obtener";
    const response = await fetch(url);

    if (response.ok) {
      const payload = await response.json();
      setVehiculos(payload);
    } else {
      console.error("Error al obtener los contactos");
    }
  };

  console.log(vehiculos);

  useEffect(() => {
    recuperarVehiculos();
  }, []);

  return (

    <Row className="mt-5">
      <Col sm="12">
        <Card>
          <CardHeader>
            <h5> Lista de Vehiculos</h5>
          </CardHeader>
          <CardBody>
            <Button size="sm" color="success">Nuevo Vehiculo</Button>
            <hr></hr>
            <TablaVehiculos />
          </CardBody>
        </Card>
      </Col>
    </Row>

  );


}

export default Vehiculos;