import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { throwError as observableThrowError, Observable } from 'rxjs';
import { api } from './api.routes';
import { catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class CategoriesService {

  constructor(
    private http: HttpClient
    ) { }

  public obtenerCategorias(): Observable<Array<any>>{
    return this.http.get<Array<any>>(api.categories.buscarTodas)
                    .pipe(catchError(this.errorHandler));
  }

  errorHandler(error : HttpErrorResponse) {
    return observableThrowError(error.message || 'Server Error');
  }
}
