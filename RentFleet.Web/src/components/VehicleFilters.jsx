import React from 'react'

function VehicleFilters({
    searchTerm,
    setSearchTerm,
    selectedFuel,
    setSelectedFuel,
    selectedTransmission,
    setSelectedTransmission,
    selectedCategory,
    setSelectedCategory
}) {
    return (
        <div className="row mb-4">
            <div className="col-md-6">
                <input
                    type="text"
                    className='form-control'
                    placeholder='🔍 Procurar veículo'
                    value={searchTerm}
                    onChange={(e) => setSearchTerm(e.target.value)}
                />
            </div>

            <div className="col-md-3">
                <select
                    className="form-select"
                    value={selectedFuel}
                    onChange={(e) => setSelectedFuel(e.target.value)}
                >
                    <option value="">Todos os combustíveis</option>
                    <option value="Gasolina">Gasolina</option>
                    <option value="Gasóleo">Gasóleo</option>
                </select>
            </div>

            <div className="col-md-3">
                <select
                    className="form-select"
                    value={selectedTransmission}
                    onChange={(e) => setSelectedTransmission(e.target.value)}
                >
                    <option value="">Todos as Transmissões</option>
                    <option value="Manual">Manual</option>
                    <option value="Automática">Automática</option>
                </select>
            </div>

            <div className="col-md-3">
                <select
                    className="form-select"
                    value={selectedCategory}
                    onChange={(e) => setSelectedCategory(e.target.value)}
                >
                    <option value="">Todos as Categorias</option>
                    <option value="Pequeno">Pequeno</option>
                    <option value="Médio">Médio</option>
                    <option value="Grande">Grande</option>
                    <option value="SUV">SUV</option>
                    <option value="Premium">Premium</option>
                    <option value="Carrinha">Carrinha</option>
                </select>
            </div>
        </div>
    )
}

export default VehicleFilters
