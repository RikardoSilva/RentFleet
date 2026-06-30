import React from 'react'
import { Link } from 'react-router-dom'

function VehicleCard({ vehicle }) {
    return (
        <div className="col-md-4 mb-4">
            <div className="card shadow h-100">
                <div className="card-body">
                    <div>
                        <div className='text-center mb-3'>
                            <h4 className="mb-2">
                                {vehicle.brand} {vehicle.model}
                            </h4>

                            <div className="d-flex justify-content-center align-items-center gap-2">
                                <span className="badge bg-dark">
                                    {vehicle.licensePlate}
                                </span>

                                <span className="badge bg-light text-dark border">
                                    {vehicle.category}
                                </span>
                            </div>
                        </div>
                    </div>

                    <div className="mb-3">
                        <p className="mb-1">
                            <strong>⛽</strong> {vehicle.fuelType}
                        </p>
                        <p className="mb-1">
                            <strong>⚙️</strong> {vehicle.transmission}
                        </p>
                    </div>

                    <Link
                        to={`/vehicles/${vehicle.id}`}
                        className="btn btn-outline-dark w-100 mt-3"
                    >
                        🔍 Ver detalhes
                    </Link>
                </div>
            </div>
        </div >
    )
}

export default VehicleCard
