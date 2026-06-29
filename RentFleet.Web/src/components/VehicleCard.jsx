import React from 'react'

function VehicleCard({ vehicle }) {
    return (
        <div className="col-md-4 mb-4">
            <div className="card shadow h-100">
                <div className="card-body">
                    <div className="d-flex justify-content-between align-items-start">
                        <div>
                            <h4 className="mb-1">
                                {vehicle.brand} {vehicle.model}
                            </h4>

                            <span className="text-muted">
                                {vehicle.category}
                            </span>
                        </div>

                        <span className="badge bg-dark">
                            {vehicle.licensePlate}
                        </span>
                    </div>

                    <hr />
                    <p><strong>Combustível:</strong> {vehicle.fuelType}</p>
                    <p><strong>Transmissão:</strong> {vehicle.transmission}</p>
                    <p><strong>Ano:</strong> {vehicle.year}</p>
                    <p><strong>Quilómetros:</strong> {vehicle.mileage}</p>
                    <p><strong>Potência:</strong> {vehicle.horsepower} cv</p>
                </div>
            </div>
        </div >
    )
}

export default VehicleCard
