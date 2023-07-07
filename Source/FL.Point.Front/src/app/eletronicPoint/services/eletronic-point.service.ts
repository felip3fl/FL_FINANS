import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { EletronicPoint } from "src/app/models/eletronicPoint";
import { BaseHttpService } from "src/app/services/BaseHttpService";

@Injectable({providedIn: 'root'})
export class EletronicPointService extends BaseHttpService<EletronicPoint> {
    constructor(httpClient: HttpClient) {
        super(httpClient);
    }
}