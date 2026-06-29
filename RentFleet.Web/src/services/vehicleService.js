const API_URL = "https://localhost:7004/api/Vehicles"

export async function getVehicles() {
    const response = await fetch(API_URL)

    if (!response.ok)
        throw new Error("Erro ao carregar veículos")

    return await response.json
}