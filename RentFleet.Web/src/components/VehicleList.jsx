import React from 'react'
import EmptyState from './EmptyState'
import VehicleCard from './VehicleCard'

function VehicleList({ vehicles, onClearFilters }) {
    return (
        <div className='container'>
            <div className="row">
                {vehicles.length === 0 ? (
                    <EmptyState onClearFilters={onClearFilters} />
                ) : (
                    vehicles.map(vehicle => (
                        <VehicleCard key={vehicle.id} vehicle={vehicle} />
                    ))
                )}
            </div>
        </div>
    )
}

export default VehicleList
