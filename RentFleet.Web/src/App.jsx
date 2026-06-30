import { Routes, Route } from "react-router-dom"
import Home from "./pages/Home"
import VehicleDetails from "./pages/VehicleDetails"

function App() {
  return (
    <Routes>
      <Route path="/" element={<Home />} />
      <Route path="/vehicles/:id" element={<VehicleDetails />} />
    </Routes>
  )
}

export default App
