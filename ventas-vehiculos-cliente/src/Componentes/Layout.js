import { Col, Container, Row } from "reactstrap";
import Sidebar from "./Sidebar";
import { Outlet } from "react-router-dom";

const Layout = () => {

  return (

    <div className="d-flex">

      <Sidebar />

      <Container fluid className="">
        <Outlet />
      </Container>

    </div>

  );

}

export default Layout;