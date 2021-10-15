import { environment } from 'src/environments/environment';

export const api = {
    categories: {
        buscarTodas: `${environment.apiUrl}/categories`
    },
    shippers: {
        add: `${environment.apiUrl}/shippers/add`,
        buscarPorId: (id: number) => `${environment.apiUrl}/shippers/${id}`,
        buscarTodos: `${environment.apiUrl}/shippers`,
        delete: (id : number) => `${environment.apiUrl}/shippers/delete/${id}`,
        update: (id : number) => `${environment.apiUrl}/shippers/update/${id}`
    }
    // Crear un objeto por cada controller de BE.
}