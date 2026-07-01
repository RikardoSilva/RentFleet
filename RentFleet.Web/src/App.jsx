import { Routes, Route } from "react-router-dom"
import Home from "./pages/Home"
import VehicleDetails from "./pages/VehicleDetails"
import CreateVehicle from "./pages/CreateVehicle"

function App() {
  return (
    <Routes>
      <Route path="/" element={<Home />} />
      <Route path="/vehicles/:id" element={<VehicleDetails />} />
      <Route path="/vehicles/create" element={<CreateVehicle />} />
    </Routes>
  )
}

export default App
