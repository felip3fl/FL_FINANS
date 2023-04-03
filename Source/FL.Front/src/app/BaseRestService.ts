import { AppComponent } from "./app.component";
import { HttpClient,HttpHeaders } from "@angular/common/http";
import { catchError, Observable, retry } from "rxjs";

export abstract class BaseRestService<T> {

    public endpointUrl: string = "";
    private maxRetries = 1;

    httpOptions = {
        Headers: new HttpHeaders({'Content-Type': 'application/json', responseType: "json"}),
    }

    constructor(private httpClient: HttpClient, private appComponent: AppComponent) {
        
    }

    get(endpoint: string, isBlob?: boolean): Observable<T[]>
    {
        this.setEndpoint("GET", endpoint);

        this.httpOption = {
            Headers: new HttpHeaders({'Content-Type': 'application/json', responseType: "json"}),
        }

        return this.httpClient
        .get<T[]>(this.getEndpoint(),this.httpOptions)
        .pipe(
            retry(this.maxRetries),
            catchError(this.handleError)
        )
    }

    setEndpoint(httpVerb: string, endpoint:string){
        this.endpointUrl = endpoint;
    }
}