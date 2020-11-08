import { MarkerData } from './../../DTO/Data/markerData';
import { Injectable } from '@angular/core';
import { MarkerCommService } from '../commServicesAbstract/marker-comm.service';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Response } from 'src/app/DTO/Responses/Response';
import { AllMarkerRequest } from 'src/app/DTO/Requests/get-all-markers-request';
import { CreateMarkerRequest } from 'src/app/DTO/Requests/Create-marker-request';

@Injectable({
  providedIn: 'root'
})
export class RemoteMarkerService implements MarkerCommService{

  constructor(private httpClient : HttpClient) { }

  getAllMarkersByDocId(request: AllMarkerRequest): Observable<Response> {
    return this.httpClient.post<Response>('/api/GetAllMarkersCtrl', request);
  }

  createMarker(request: CreateMarkerRequest): Observable<Response> {
    return this.httpClient.post<Response>('api/CreateMarkerCtrl', request)
  }

  RemoveAllMarkersByDoc(request: AllMarkerRequest): Observable<Response> {
    return this.httpClient.post<Response>('api/RemoveAllMarkersCtrl', request)
  }
}
