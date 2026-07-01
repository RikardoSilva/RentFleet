import { Link } from "react-router-dom"
function CreateVehicle() {
  return (
    <div>
      <div className="container mt-4">
      <Link to="/" className="btn btn-outline-secondary mb-4">
        ← Voltar à frota
      </Link>

      <div className="card shadow-sm">
        <div className="card-body p-4">
          <h1 className="mb-3 ">Adicionar viatura</h1>
          <p className="text-muted">
            Aqui será criado o formulário para adicionar uma nova viatura.
          </p>
        </div>
      </div>
    </div>
    </div>
  )
}

export default CreateVehicle
