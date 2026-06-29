import React from 'react'

function ResultsSummary({ hasActiveFilters, resultCount, onClearFilters }) {
    if (!hasActiveFilters)
        return null

    return (
        <div className="container">
            <div className="d-flex justify-content-between align-items-start mb-4 text-muted">
                <span>
                    {resultCount === 1
                        ? "1 veículo encontrado"
                        : `${resultCount} veículos encontrados`}
                </span>

                <button
                    className='btn btn-outline-secondary btn-sm'
                    onClick={clearFilters}
                >
                    Limpar filtros
                </button>
            </div>
        </div>
    )
}

export default ResultsSummary
