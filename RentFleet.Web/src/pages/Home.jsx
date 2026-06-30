import { useEffect, useState } from 'react'
import '../App.css'
import Navbar from '../components/Navbar'
import VehicleFilters from '../components/VehicleFilters'
import VehicleList from '../components/VehicleList'
import ResultsSummary from '../components/ResultsSummary'
import { getVehicles } from '../services/vehicleService'

function Home() {
  const [vehicles, setVehicles] = useState([])
  const [searchTerm, setSearchTerm] = useState("")
  const [selectedFuel, setSelectedFuel] = useState("")
  const [selectedTransmission, setSelectedTransmission] = useState("")
  const [selectedCategory, setSelectedCategory] = useState("")

  useEffect(() => {
    getVehicles()
    .then(data => setVehicles(data))
    .catch(error => console.error(error))
  }, [])

  const filteredVehicles = vehicles.filter(vehicle => {
    const matchesSearch =
      `${vehicle.brand} ${vehicle.model}`
        .toLowerCase()
        .includes(searchTerm.toLowerCase())

    const matchesFuel =
      selectedFuel === "" || vehicle.fuelType === selectedFuel

    const matchesTransmission =
      selectedTransmission === "" || vehicle.transmission === selectedTransmission

    const matchesCategory =
      selectedCategory === "" || vehicle.category === selectedCategory

    return matchesSearch && matchesFuel && matchesTransmission && matchesCategory
  })

  const hasActiveFilters =
    searchTerm !== "" ||
    selectedFuel !== "" ||
    selectedTransmission !== "" ||
    selectedCategory !== ""

  function clearFilters() {
    setSearchTerm("")
    setSelectedFuel("")
    setSelectedTransmission("")
    setSelectedCategory("")
  }

  return (
    <>
      <Navbar />

      <VehicleFilters
        searchTerm={searchTerm}
        setSearchTerm={setSearchTerm}
        selectedFuel={selectedFuel}
        setSelectedFuel={setSelectedFuel}
        selectedTransmission={selectedTransmission}
        setSelectedTransmission={setSelectedTransmission}
        selectedCategory={selectedCategory}
        setSelectedCategory={setSelectedCategory}
      />

      <ResultsSummary
      hasActiveFilters={hasActiveFilters}
      resultCount={filteredVehicles.length}
      onClearFilters={clearFilters}
      />

      <VehicleList
        vehicles={filteredVehicles}
        onClearFilters={clearFilters}
      />
    </>
  )
}

export default Home
