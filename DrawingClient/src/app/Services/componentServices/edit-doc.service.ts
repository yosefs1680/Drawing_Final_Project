import { buffer, filter, map, pairwise, switchMap, take, takeUntil } from 'rxjs/operators';
import { MarkerService } from './marker.service';
import { fromEvent, Subject } from 'rxjs';
import { DrawingService } from './drawing.service';
import { Injectable } from '@angular/core';
import { Point } from '../../DTO/Data/point';
import { Rectangle } from 'src/app/DTO/Data/rectangle';
import { Ellipse } from 'src/app/DTO/Data/ellipse';

@Injectable()
export class EditDocService {

  fColor: string = "#000000"; //black
  bColor: string = "#000000";

  constructor(
    private drawingService: DrawingService,
    private markerService: MarkerService) {
     }

  docId: string
  mode: string = 'Rectangle'
  
  CreateShape: { [shapeMode: string]: any } =
    {
      Rectangle: this.CreateRect.bind(this),
      Ellipse: this.createEllipse.bind(this)
    }

  polySubject: Subject<Point> = new Subject<Point>()

  freeDraw(pointsArr: Array<Point>) {
    this.drawingService.onDrawFree.next(pointsArr)
    this.polySubject.next(pointsArr[0])
    this.polySubject.next(pointsArr[1])
  }

  drawShape(pointsArr: Array<Point>) {
    var marker = this.CreateShape[this.mode](pointsArr);
    if (marker.markerType == 'Rectangle') {
      this.drawingService.drawRect(marker)
    }
    if (marker.markerType == 'Ellipse') {
      this.drawingService.drawEllipse(marker)
    }

    this.markerService.createMarker(this.docId, marker)
    this.markerService.onCreateMarkerOk.pipe(take(1))
      .subscribe((res: any) => {
      })
  }

  clearMarkers(docId: string) {
   // this.drawingService.clearCanvas();
    this.markerService.RemoveAllMarkers(docId)
    this.markerService.onRemoveAllMarkersOk.subscribe(res => {
      this.drawingService.clearCanvas();
    })
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

  CreateRect(shapePoly: Array<Point>): Rectangle {
    //if (shapePoly.length==0)return
    var rec = new Rectangle()
    rec.markerType = 'Rectangle'
    rec.foreColor = this.fColor;
    rec.backColor = this.bColor;
    var topy = shapePoly.reduce((acc, pt) => acc = (acc.y < pt.y) ? acc : pt).y;
    var btny = shapePoly.reduce((acc, pt) => acc = (acc.y > pt.y) ? acc : pt).y;
    var lftx = shapePoly.reduce((acc, pt) => acc = (acc.x < pt.x) ? acc : pt).x;
    var rightx = shapePoly.reduce((acc, pt) => acc = (acc.x > pt.x) ? acc : pt).x;
    var startPos = new Point(lftx, topy);
    var radius = new Point(rightx - startPos.x, btny - startPos.y);
    rec.markerLoc = { position: startPos, radius: radius }
    return rec;
  }

  createEllipse(shapePoly: Array<Point>): Ellipse {
    var elps = new Ellipse();
    elps.markerType = 'Ellipse'
    elps.foreColor = this.fColor;
    elps.backColor = this.bColor;
    var center = new Point(0, 0)
    center = center.add(shapePoly[0])
    center = shapePoly.reduce((acc: Point, pt: Point) => new Point(acc.x, acc.y).add(pt))
    center = center.div(shapePoly.length)
    var radius = new Point(0, 0)
    radius = shapePoly.reduce((acc: Point, pt: Point) => new Point(acc.x, acc.y).add(new Point(Math.abs(pt.x - center.x), Math.abs(pt.y - center.y))))
    radius = radius.div(shapePoly.length)
    elps.markerLoc = { position: center, radius: radius };
    return elps;
  }

  setMode(mode: string) {
    this.mode = mode
  }
}
