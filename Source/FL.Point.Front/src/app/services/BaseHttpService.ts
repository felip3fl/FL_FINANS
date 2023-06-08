import { environment } from 'src/environments/environment';
import { Observable, throwError } from 'rxjs';
import { HttpClient, HttpErrorResponse, HttpHeaders, } from '@angular/common/http';
import { retry, catchError } from 'rxjs/operators';
import { AppComponent } from '../app.component';
import { Injectable, ViewChild } from '@angular/core';
import { BaseLogService } from './BaseLogService';

@Injectable({ providedIn: 'root' })
export abstract class BaseHttpService<T> extends BaseLogService {
  public modalTitle: string = '';
  public modalMessage: string = '';
  public modalType: string = '';
  protected baseUrl: string = environment.baseApiUrl;
  protected endpointUrl: string = '';
  private maxRetries: number = 0;

  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json',
      responseType: 'json',
    }),
  };

  constructor(
    private httpClient: HttpClient,
    private appComponent: AppComponent
  ) { 
    super();
  }

  getEndpoint(): string {
    return `${this.baseUrl}${this.endpointUrl}`;
  }

  setEndpoint(httpVerb: string, endpoint: string) {
    this.endpointUrl = endpoint;

    //!environment.production ? console.log(`${httpVerb} - ${this.getEndpoint()}`) : null
  }

  get(endpoint: string, isBlob?: boolean): Observable<T[]> {
    this.setEndpoint('GET', endpoint);

    if (isBlob) {
      this.httpOptions = {
        headers: new HttpHeaders({
          'Content-Type': 'application/json',
          responseType: 'blob',
        }),
      };
    } else {
      this.httpOptions = {
        headers: new HttpHeaders({
          'Content-Type': 'application/json',
          responseType: 'json',
        }),
      };
    }

    return this.httpClient
      .get<T[]>(this.getEndpoint(), this.httpOptions)
      .pipe(retry(this.maxRetries), catchError(this.handleError));
  }

  getFirstOrDefault(endpoint: string, isBlob?: boolean): Observable<T> {
    this.setEndpoint('GET', endpoint);

    if (isBlob) {
      this.httpOptions = {
        headers: new HttpHeaders({
          'Content-Type': 'application/json',
          responseType: 'blob',
        }),
      };
    } else {
      this.httpOptions = {
        headers: new HttpHeaders({
          'Content-Type': 'application/json',
          responseType: 'json',
        }),
      };
    }

    return this.httpClient
      .get<T>(this.getEndpoint(), this.httpOptions)
      .pipe(retry(this.maxRetries), catchError(this.handleError));
  }

  getById(endpoint: string, id: number): Observable<T> {
    this.setEndpoint('GET', endpoint);

    //!environment.production ? console.log(`${this.getEndpoint()}/${id}`,this.httpOptions) : null

    return this.httpClient
      .get<T>(`${this.getEndpoint()}/${id}`)
      .pipe(retry(this.maxRetries), catchError(this.handleError));
  }

  create(endpoint: string, item: T): Observable<T> {
    this.setEndpoint('POST', endpoint);

    //!environment.production ? console.log('payload', JSON.stringify(item)) : null

    return this.httpClient
      .post<T>(this.getEndpoint(), JSON.stringify(item), this.httpOptions)
      .pipe(retry(this.maxRetries), catchError(this.handleError));
  }

  update(endpoint: string, item: T): Observable<T> {
    this.setEndpoint('PUT', endpoint);

    //!environment.production ? console.log('payload', JSON.stringify(item)) : null

    return this.httpClient
      .put<T>(this.getEndpoint(), JSON.stringify(item), this.httpOptions)
      .pipe(retry(this.maxRetries), catchError(this.handleError));
  }

  post(endpoint: string, item: T): Observable<T> {
    this.setEndpoint('POST', endpoint);

    //!environment.production ? console.log('payload', JSON.stringify(item)) : null

    return this.httpClient
      .post<T>(this.getEndpoint(), JSON.stringify(item), this.httpOptions)
      .pipe(retry(this.maxRetries), catchError(this.handleError));
  }

  delete(endpoint: string) {
    this.setEndpoint('DELETE', endpoint);

    return this.httpClient
      .delete(this.getEndpoint(), this.httpOptions)
      .pipe(retry(this.maxRetries));
  }

  private handleError = (error: HttpErrorResponse, content: any) => {
    let errorMessage = '';

    if (error.error instanceof ErrorEvent) {
      //error client
      errorMessage = error.error.message;
    } else {
      //error server
      errorMessage = `An error happened during the last request at '${error.url}'.\nStatus: ${error.status} - ${error.statusText} \nDetails: :${error.error} - ${error.message}`;
    }

    //this.openModalException(content, "Erro", errorMessage, "");
    //console.warn(errorMessage);
    alert(errorMessage);

    return throwError(error);
  };
}
