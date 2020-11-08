import { Response } from '../../DTO/Responses/Response';
import { Subject } from 'rxjs';
import { Injectable } from '@angular/core';
import { MarkerData } from '../../DTO/Data/markerData';
import { MarkerCommService } from '../commServicesAbstract/marker-comm.service';
import { UserService } from './user.service';

@Injectable({
  providedIn:'root'
})
export class MarkerService {

  constructor(
    private markerCommService: MarkerCommService,
    private userService: UserService
  ) { }

  ResponseSubject: { [responseType: string]: Subject<any> } = {

    CreateMarkerResponseOk: new Subject<any>(),
    CreateMarkerResponseErr: new Subject<any>(),

    GetAllMarkersResponseOk: new Subject<Array<any>>(),
    GetAllMarkersResponseErr: new Subject<any>(),

    RemoveMarkerResponseOk: new Subject<any>(),
    RemoveMarkerResponseErr: new Subject<any>(),

    RemoveAllMarkersResponseOk: new Subject<any>(),
    RemoveAllMarkersResponseErr: new Subject<any>()
  } 

  getAllMarkersByDocId(docId: string) {
    var param = { docId: docId };
    this.markerCommService.getAllMarkersByDocId(param)
      .subscribe( (response: Response) => {
        console.log(response);
        this.ResponseSubject[response.responseType].next(response)
      })
      
  }
  createMarker(docId: string, Marker: MarkerData) {
    var request = {
      markerData: {
        owner: this.userService.userId,
        docId: docId,
        markerId: this.getUniqeId(),
        markerType: Marker.markerType,
        markerLoc: { position: Marker.markerLoc.position, radius: Marker.markerLoc.radius },
        foreColor: Marker.foreColor,
        backColor: Marker.backColor,
      }
    }
    this.markerCommService.createMarker(request)
  .subscribe((response: Response) =>
    this.ResponseSubject[response.responseType].next(response))
  }

RemoveAllMarkers(docId: string) {
  this.markerCommService.RemoveAllMarkersByDoc({ docId: docId })
    .subscribe((response: Response) =>
      this.ResponseSubject[response.responseType].next(response))
}

private getUniqeId() {
  // Math.random should be unique because of its seeding algorithm.
  // Convert it to base 36 (numbers + letters), and grab the first 9 characters
  // after the decimal.
  return '_' + Math.random().toString(36).substr(2, 9);
}

get onCreateMarkerOk() { return this.ResponseSubject['CreateMarkerResponseOk'] }
get onGetAllMarkersOk() { return this.ResponseSubject['GetAllMarkersResponseOk'] }
get onRemoveAllMarkersOk() { return this.ResponseSubject['RemoveAllMarkersResponseOk'] }

}
