import { Route, Routes } from "react-router-dom";
import { BrowserRouter } from "react-router-dom";
import Layout from "./Componentes/Layout";
import Vehiculos from "./Pages/Vehiculos";


const App = () => {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Layout />} >
          <Route path="/Vehiculos" element={<Vehiculos />} />
        </Route>
      </Routes>
    </BrowserRouter>
  );
}

export default App;
