import { ElementRef, Injectable, ViewChild } from '@angular/core';
import { Ellipse } from 'src/app/DTO/Data/ellipse';
import { Point } from 'src/app/DTO/Data/point';
import { Rectangle } from 'src/app/DTO/Data/rectangle';

@Injectable({
  providedIn: 'root'
})
export class CreateShapeService {

  @ViewChild('freeDrawCanvas') freeDrawCanvasRef: ElementRef<HTMLCanvasElement>;
  @ViewChild('shapeCanvas') canvasShapeRef: ElementRef<HTMLCanvasElement>;
  
  fColor: string = "#000000"; //black
  bColor: string = "#000000";
  constructor() { }
    
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
    radius = shapePoly.reduce((acc: Point, pt: Point) => new Point(acc.x, acc.y)
      .add(new Point(Math.abs(pt.x - center.x), Math.abs(pt.y - center.y))))
    radius = radius.div(shapePoly.length)
    elps.markerLoc = { position: center, radius: radius };
    return elps;
  }

}
