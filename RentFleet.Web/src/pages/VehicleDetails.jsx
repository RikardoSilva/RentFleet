import { useEffect, useState } from "react"
import { useParams, Link } from "react-router-dom"
import { getVehicleById } from "../services/vehicleService"

function VehicleDetails() {
    const { id } = useParams()

    const [vehicle, setVehicle] = useState(null)
    const [error, setError] = useState("")

    useEffect(() => {
        getVehicleById(id)
            .then(data => setVehicle(data))
            .catch(() => setError("Viatura não encontrada."))
    }, [id])

    if (error) {
        return (
            <div className="container mt-4">
                <Link to="/" className="btn btn-outline-secondary mb-4">
                    ← Voltar
                </Link>

                <div className="alert alert-warning text-center p-4">
                    <h3>Viatura não encontrada 😟</h3>
                    <p>Esta viatura não existe ou foi removida.</p>
                </div>
            </div>
        )
    }

    if (!vehicle) {
        return (
            <div className="container mt-4">
                <p>A carregar viatura...</p>
            </div>
        )
    }

    return (
        <div className='container mt-4'>
            <Link to="/" className="btn btn-outline-secondary mb-4">
                ← Voltar
            </Link>

            <div className="container mt-4">
                <div className="card-body">
                    <h1>
                        {vehicle.brand} {vehicle.model}
                    </h1>

                    <p className="text-muted">
                        {vehicle.category}
                    </p>

                    <hr />

                    <p><strong>Matrícula:</strong> {vehicle.licensePlate}</p>
                    <p><strong>Combustível:</strong> {vehicle.fuelType}</p>
                    <p><strong>Transmissão:</strong> {vehicle.transmission}</p>
                    <p><strong>Ano:</strong> {vehicle.year}</p>
                    <p><strong>Quilómetros:</strong> {vehicle.mileage}</p>
                    <p><strong>Potência:</strong> {vehicle.horsepower} cv</p>
                    <p><strong>Cilindrada:</strong> {vehicle.engineCapacity}</p>
                </div>
            </div>
        </div>
    )
}

export default VehicleDetails
