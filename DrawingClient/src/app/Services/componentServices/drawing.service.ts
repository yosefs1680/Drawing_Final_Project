import { buffer, filter, map, pairwise, switchMap, take, takeUntil } from 'rxjs/operators';
import { MarkerService } from './marker.service';
import { fromEvent, Subject } from 'rxjs';
import { Rectangle } from 'src/app/DTO/Data/rectangle';
import { Ellipse } from 'src/app/DTO/Data/ellipse';
import { Point } from './../../DTO/Data/point';
import { Injectable } from '@angular/core';
import { MarkerData } from 'src/app/DTO/Data/markerData';
import { CreateShapeService } from './create-shape.service';

@Injectable({
  providedIn: 'root'
})
export class DrawingService {

 
  docId: string
  mode: string = 'Rectangle'

  constructor(private markerService: MarkerService,
    private createShapeService: CreateShapeService,) { }

  polySubject: Subject<Point> = new Subject<Point>()

  CreateShape: { [shapeMode: string]: any } = {
    Rectangle: this.createShapeService.CreateRect.bind(this),
    Ellipse: this.createShapeService.createEllipse.bind(this)
  }
  DrawingSubject: { [DrawingType: string]: Subject<any> } = {
    DrawFree: new Subject<any>(),
    DrawElps: new Subject<any>(),
    DrawRect: new Subject<any>(),
    ClearCanvas: new Subject()
  }

  mouseEvtListening(canvas: HTMLCanvasElement) {
    var mousedown$ = fromEvent(canvas, 'mousedown');
    var mousemove$ = fromEvent(canvas, 'mousemove');
    var mouseup$ = fromEvent(canvas, 'mouseup');

    mousedown$.pipe(
      switchMap(() =>
        mousemove$.pipe(
          takeUntil(mouseup$),
          takeUntil(fromEvent(canvas, 'mouseleave')),
          pairwise())))// send data just after two points
      .pipe(map((res: [MouseEvent, MouseEvent]) => {
        const rect = canvas.getBoundingClientRect();
        return res.map(point => {
          return {
            x: point.clientX - rect.left,
            y: point.clientY - rect.top
          }
        })
      }))
      .subscribe((res: Array<Point>) => {
        this.freeDraw(res)
      })

    this.polySubject.pipe(
      buffer(mouseup$)
    ).pipe(filter(res => res.length > 0))
      .subscribe(res =>
        this.drawShape(res))
  }

  freeDraw(pointsArr: Array<Point>) {
    this.onDrawFree.next(pointsArr)
    this.polySubject.next(pointsArr[0])
    this.polySubject.next(pointsArr[1])
  }
  drawShape(pointsArr: Array<Point>) {
    var marker = this.CreateShape[this.mode](pointsArr);

    if (marker.markerType == 'Rectangle') {
      this.DrawingSubject['DrawRect'].next(marker)
    }
    if (marker.markerType == 'Ellipse') {
      this.DrawingSubject['DrawElps'].next(marker)
    }
    //send data to server:
    this.markerService.createMarker(this.docId, marker)
    this.markerService.onCreateMarkerOk.pipe(take(1))
      .subscribe((res: any) => {
      })
  }

  clearMarkers(docId: string) {
    // this.drawingService.clearCanvas();
    this.markerService.RemoveAllMarkers(docId)
    this.markerService.onRemoveAllMarkersOk
      .subscribe(res => {
        this.DrawingSubject['ClearCanvas'].next(res);
      })
  }

 

  setMode(mode: string) {
    this.mode = mode
  }

  get onDrawFree() { return this.DrawingSubject['DrawFree'] }
  get onDrawEllipse() { return this.DrawingSubject['DrawElps'] }
  get onDrawRectangle() { return this.DrawingSubject['DrawRect'] }
  get onClearCanvas() { return this.DrawingSubject['ClearCanvas'] }

  // scal(pnt: Point) {
  //   return new Point(pnt.x * (this.canvasShapeRef.nativeElement.width / 487),
  //     pnt.y * (this.canvasShapeRef.nativeElement.height / 246))
  // }
}
