import { Point } from './../../DTO/Data/point';
import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';
import { MarkerData } from 'src/app/DTO/Data/markerData';

@Injectable({
  providedIn: 'root'
})
export class DrawingService {

  constructor() { }

  DrawingSubject: { [DrawingType: string]: Subject<any> } = {
    FreeDraw: new Subject<any>(),
    EllipseDraw: new Subject<any>(),
    RectangleDraw: new Subject<any>(),
    ClearCanvas: new Subject()
  }

  clearCanvas() {
    this.DrawingSubject['ClearCanvas'].next();
  }

  freeDraw(points: Array<Point>) {
    this.DrawingSubject['FreeDraw'].next(points);
  }
  drawEllipse(Marker: MarkerData) {
    this.DrawingSubject['EllipseDraw'].next(Marker);
  }
  drawRect(Marker: MarkerData) {
    this.DrawingSubject['RectangleDraw'].next(Marker);
  }

  get onDrawEllipse() { return this.DrawingSubject['EllipseDraw'] }
  get onDrawRectangle() { return this.DrawingSubject['RectangleDraw'] }
  get onDrawFree() { return this.DrawingSubject['FreeDraw'] }
  get onClearCanvas() { return this.DrawingSubject['ClearCanvas'] }
}
