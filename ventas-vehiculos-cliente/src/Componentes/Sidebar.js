import { NavLink } from "react-router-dom";

const Sidebar = () => {
  return (
    <div className="d-flex vh-100">
      <div className="bg-dark border-right p-3" id="sidebar">
        <h3 className="text-light mx-3 text-center">Venta de vehiculos</h3>
        <hr className="text-light" />

        <div className="list-group">
          <NavLink to="/Vehiculos" className="list-group-item bg-dark text-light text-center "> Vehiculos</NavLink>
          <NavLink to="/Vehiculos" className="list-group-item bg-dark text-light text-center "> Tipos de vehiculo</NavLink>
        </div>

      </div>
    </div >
  );
};

export default Sidebar;