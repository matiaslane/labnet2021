import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { throwError as observableThrowError, Observable } from 'rxjs';
import { ShippersModel } from '../modules/shippers/models/shippers-model';
import { api } from './api.routes';
import { catchError } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class ShippersService {

  constructor(
    private http : HttpClient
  ) { }

  public obtenerShippersPorId(shipperId: number): Observable<any>{
    return this.http.get<any>(api.shippers.buscarPorId(shipperId))
                    .pipe(catchError(this.errorHandler));
  }
  
  public obtenerShippers(): Observable<Array<any>>{
    return this.http.get<Array<any>>(api.shippers.buscarTodos)
                    .pipe(catchError(this.errorHandler));
  }

  public crearShippers(shipperRequest : ShippersModel) : Observable<any>{
    return this.http.post(api.shippers.add,shipperRequest)
                    .pipe(catchError(this.errorHandler));
  }

  public deleteShippers(shipperId : number ) : Observable<any>{
    return this.http.delete(api.shippers.delete(shipperId))
                    .pipe(catchError(this.errorHandler));
  }

  public updateShippers(shipperId: number , command: ShippersModel){
    return this.http.put(api.shippers.update(shipperId),command)
                    .pipe(catchError(this.errorHandler))
  }

  errorHandler(error : HttpErrorResponse) {
    return observableThrowError(error.status || 'Server Error');
  }
  
}
