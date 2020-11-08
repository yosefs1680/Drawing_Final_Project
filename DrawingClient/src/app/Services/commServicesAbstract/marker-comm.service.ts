import { MarkerData } from './../../DTO/Data/markerData';
import { Response } from './../../DTO/Responses/Response';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { AllMarkerRequest } from 'src/app/DTO/Requests/get-all-markers-request';
import { CreateMarkerRequest } from 'src/app/DTO/Requests/Create-marker-request';

@Injectable({
  providedIn: 'root'
})
export abstract class MarkerCommService {

  abstract getAllMarkersByDocId(request: AllMarkerRequest);

  abstract createMarker(request: CreateMarkerRequest);

  abstract RemoveAllMarkersByDoc(request: AllMarkerRequest);

}
