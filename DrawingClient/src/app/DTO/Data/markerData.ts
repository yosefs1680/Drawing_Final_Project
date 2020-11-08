import { MarkerLocation } from "./marker-location"

export class MarkerData {
    owner: string
    docId: string
    markerId: string = null;
    markerType: string
    markerLoc: MarkerLocation
    foreColor: string
    backColor : string
}
