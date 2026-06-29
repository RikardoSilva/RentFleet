import React from 'react'

function EmptyState({ onClearFilters }) {
    return (
        <div className='col-12'>
            <div className="alert alert-warning text-center p-4">
                <h4>Nenhum veículo encontrado 😟</h4>
                <p className="mb-3">
                    Não existem veículos que correspondam à pesquisa.
                </p>

                <button
                    className="btn btn-warning"
                    onClick={onClearFilters}
                >
                    Limpar filtros
                </button>
            </div>
        </div>
    )
}

export default EmptyState
