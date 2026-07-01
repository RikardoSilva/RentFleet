import { useEffect, useState } from "react"
import './VehicleDetails.css'
import { useParams, Link } from "react-router-dom"
import { getVehicleById } from "../services/vehicleService"
import placeholderCar from '../assets/images/placeholder-car.png'

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
                <Link to="/" className="btn btn-outline-secondary mb-4 vehicle-details-back">
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
        <div className="container mt-4 vehicle-details-page">

            <Link to="/" className="btn btn-outline-secondary vehicle-details-back">
                ← Voltar à frota
            </Link>

            <div className="vehicle-details-card">

                <div className="vehicle-hero">

                    <img
                        src={vehicle.imageURL || placeholderCar}
                        alt={`${vehicle.brand} ${vehicle.model}`}
                        className="vehicle-image"
                        onError={(e) => {
                            e.currentTarget.src = placeholderCar
                        }}
                    />

                    <div>
                        <h1 className="vehicle-title">
                            {vehicle.brand} {vehicle.model}
                        </h1>

                        <div className="vehicle-badges">
                            <span className="badge bg-light text-dark border">
                                {vehicle.category}
                            </span>

                            <span className="badge bg-dark">
                                {vehicle.licensePlate}
                            </span>
                        </div>

                        <div className="vehicle-status">
                            ● Disponível
                        </div>
                    </div>

                </div>

                <div className="vehicle-specs">

                    <div className="vehicle-spec-card">
                        <small>Combustível</small>
                        <h5>{vehicle.fuelType}</h5>
                    </div>

                    <div className="vehicle-spec-card">
                        <small>Transmissão</small>
                        <h5>{vehicle.transmission}</h5>
                    </div>

                    <div className="vehicle-spec-card">
                        <small>Ano</small>
                        <h5>{vehicle.year}</h5>
                    </div>

                    <div className="vehicle-spec-card">
                        <small>Quilómetros</small>
                        <h5>{vehicle.mileage} km</h5>
                    </div>

                    <div className="vehicle-spec-card">
                        <small>Potência</small>
                        <h5>{vehicle.horsepower} cv</h5>
                    </div>

                    <div className="vehicle-spec-card">
                        <small>Cilindrada</small>
                        <h5>{vehicle.engineCapacity} cc</h5>
                    </div>

                </div>

            </div>

        </div>
    )
}

export default VehicleDetails
