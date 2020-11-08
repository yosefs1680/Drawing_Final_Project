import { map } from 'rxjs/operators';
import { Observable, Subject } from 'rxjs';
import { DrawingService } from '../../Services/componentServices/drawing.service'
import { Point } from '../../DTO/Data/point';
import { ElementRef, Input, ViewChild, AfterViewInit, Component, OnInit } from '@angular/core';
import { Ellipse } from '../../DTO/Data/ellipse';
import { Rectangle } from '../../DTO/Data/rectangle';

@Component({
  selector: 'app-drawing',
  templateUrl: './drawing.component.html',
  styleUrls: ['./drawing.component.css']
})
export class DrawingComponent implements OnInit, AfterViewInit {

  @ViewChild('freeDrawCanvas') freeDrawCanvasRef: ElementRef<HTMLCanvasElement>;
  @ViewChild('shapeCanvas') canvasShapeRef: ElementRef<HTMLCanvasElement>;


  @Input() docId: string;
  localScreen: Point
  @Input() height;
  @Input() width;

  constructor(public drawingService: DrawingService) { }
  ngAfterViewInit(): void {
    this.freeDrawCanvasRef.nativeElement.width = this.freeDrawCanvasRef.nativeElement.offsetWidth;
    this.freeDrawCanvasRef.nativeElement.height = this.freeDrawCanvasRef.nativeElement.offsetHeight;
    this.canvasShapeRef.nativeElement.width = this.canvasShapeRef.nativeElement.offsetWidth;
    this.canvasShapeRef.nativeElement.height = this.canvasShapeRef.nativeElement.offsetHeight;
    this.localScreen = new Point(this.freeDrawCanvasRef.nativeElement.width, this.freeDrawCanvasRef.nativeElement.height);

  }

  ngOnInit(): void {
    this.drawingService.onDrawFree.subscribe(points => this.freeDraw(points[0], points[1]))
    this.drawingService.onDrawEllipse.subscribe(marker => this.drawEllipse(marker))
    this.drawingService.onDrawRectangle.subscribe(marker => this.drawRectangle(marker))
    this.drawingService.onClearCanvas.subscribe(marker => this.clearCanvas(this.canvasShapeRef.nativeElement))
  }

  drawEllipse(marker: Ellipse) {
    this.clearCanvas(this.freeDrawCanvasRef.nativeElement);
    var ctx = this.getCtx(this.canvasShapeRef.nativeElement);
    ctx.globalAlpha = 0.2;
    ctx.fillStyle = marker.backColor
    var center = marker.markerLoc.position
    var radius = marker.markerLoc.radius
    ctx.ellipse(center.x, center.y, radius.x, radius.y, 0, 0, 2 * Math.PI);
    ctx.fill()
    ctx.globalAlpha = 1.0;
    ctx.strokeStyle = marker.foreColor
    ctx.ellipse(center.x, center.y, radius.x, radius.y, 0, 0, 2 * Math.PI);
    ctx.stroke();
  }

  drawRectangle(marker: Rectangle) {
    this.clearCanvas(this.freeDrawCanvasRef.nativeElement);
    var ctx = this.getCtx(this.canvasShapeRef.nativeElement);
    ctx.globalAlpha = 0.2;
    ctx.fillStyle = marker.backColor
    var startPos = marker.markerLoc.position
    var radius = marker.markerLoc.radius
    ctx.fillRect(startPos.x, startPos.y, radius.x, radius.y);
    ctx.globalAlpha = 1.0;
    ctx.strokeStyle = marker.foreColor
    ctx.rect(startPos.x, startPos.y, radius.x, radius.y);
    ctx.stroke();
  }
  a: Point
  freeDraw(from: Point, to: Point) {
    //from = new Point(from.x, from.y).calc(originScreen, this.localScreen)
    //to = new Point(to.x, to.y).calc(originScreen, this.localScreen)
    //to = new Point(to.x, to.y).calc(originScreen, this.localScreen)
    var ctx = this.getCtx(this.freeDrawCanvasRef.nativeElement);
    console.log('from:' + from.x + "to" + to.x)
    ctx.moveTo(from.x, from.y);
    ctx.lineTo(to.x, to.y);
    ctx.stroke()
  }

  clearCanvas(canvas: HTMLCanvasElement) {
    var ctx = this.getCtx(canvas)
    ctx.clearRect(0, 0, canvas.width, canvas.height)
    ctx.stroke()
  }

  getCtx(canvas: HTMLCanvasElement): CanvasRenderingContext2D {
    var ctx = canvas.getContext('2d');
    ctx.lineCap = 'round';
    ctx.strokeStyle = '#000'
    ctx.beginPath()
    return ctx;
  }

  scal(p: Point) {
    return new Point(p.x * (this.canvasShapeRef.nativeElement.width / 487),
      p.y * (this.canvasShapeRef.nativeElement.height / 246))
  }
}
