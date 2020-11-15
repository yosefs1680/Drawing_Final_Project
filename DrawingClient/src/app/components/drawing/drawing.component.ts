import { map } from 'rxjs/operators';
import { fromEvent, Observable, Subject } from 'rxjs';
import { DrawingService } from '../../Services/componentServices/drawing.service'
import { Point } from '../../DTO/Data/point';
import { ElementRef, Input, ViewChild, AfterViewInit, Component, OnInit } from '@angular/core';
import { Ellipse } from '../../DTO/Data/ellipse';
import { Rectangle } from '../../DTO/Data/rectangle';
import { MarkerService } from 'src/app/Services/componentServices/marker.service';
import { CreateShapeService } from 'src/app/Services/componentServices/create-shape.service';
import { DocsService } from 'src/app/Services/componentServices/docs.service';
import { ActivatedRoute } from '@angular/router';
import { MarkerData } from 'src/app/DTO/Data/markerData';
import { Document } from 'src/app/DTO/Data/document'

@Component({
  selector: 'app-drawing',
  templateUrl: './drawing.component.html',
  styleUrls: ['./drawing.component.css']
})
export class DrawingComponent implements OnInit, AfterViewInit {

  @ViewChild('freeDrawCanvas') freeDrawCanvasRef: ElementRef<HTMLCanvasElement>;
  @ViewChild('shapeCanvas') canvasShapeRef: ElementRef<HTMLCanvasElement>;
  @ViewChild('fcolor') fcolor: ElementRef
  @ViewChild('bcolor') bcolor: ElementRef
  @ViewChild('Drawing', { static: true }) drawingComponent: DrawingComponent;

  doc: Document =new Document("","","","")
  markerList: Array<MarkerData>
  msg: string;

  @Input() docId: string;
  @Input() height;
  @Input() width;
  localScreen: Point

  constructor(
    private drawingService: DrawingService,
    private markerService: MarkerService,
    private docsService: DocsService,
    private route: ActivatedRoute,) { }

  ngOnInit(): void {
    var docId = this.route.snapshot.paramMap.get('docId')
    this.docsService.getDoc(docId)
      .subscribe(res => {
        this.doc = res.data
      });

    this.markerService.getAllMarkersByDocId(docId);
    this.markerService.onGetAllMarkersOk.subscribe(res => {
      this.markerList = res.data;
      this.markerList.forEach(elmt => {
        if (elmt.markerType == 'Rectangle') {
          this.drawRectangle(elmt)
        }
        if (elmt.markerType == 'Ellipse') {
          this.drawEllipse(elmt)
        }
      })
    })

    // get data from server - and operate the releavant function to modify canvas:
    this.drawingService.onDrawFree.subscribe(points => this.DrawFree(points[0], points[1]))
    this.drawingService.onDrawEllipse.subscribe(marker => this.drawEllipse(marker))
    this.drawingService.onDrawRectangle.subscribe(marker => this.drawRectangle(marker))
    this.drawingService.onClearCanvas.subscribe(marker => this.clearCanvas(this.canvasShapeRef.nativeElement))

  } //End ngOnInit

  ngAfterViewInit(): void {
    this.intialScreen()
    fromEvent(this.fcolor.nativeElement, 'change')
      .subscribe((v: any) => this.fcolor = v.target.value)
    fromEvent(this.bcolor.nativeElement, 'change')
      .subscribe((v: any) => this.bcolor = v.target.value)

    var canvasEl = this.freeDrawCanvasRef.nativeElement
    //send all enevnts to service
    this.drawingService.mouseEvtListening(canvasEl)
  }

  getDoc(docId: string) {
    this.docsService.getDoc(docId)
      .subscribe(res => {
        console.log(res)
        this.doc = res.data
      });
  }

  //========= Functions that actually Draw\clear the canvas ==========
  DrawFree(from: Point, to: Point) {
    //from = new Point(from.x, from.y).calc(originScreen, this.localScreen)
    //to = new Point(to.x, to.y).calc(originScreen, this.localScreen)
    //to = new Point(to.x, to.y).calc(originScreen, this.localScreen)
    var ctx = this.getCtx(this.freeDrawCanvasRef.nativeElement);
    console.log('from:' + from.x + "to" + to.x)
    ctx.moveTo(from.x, from.y);
    ctx.lineTo(to.x, to.y);
    ctx.stroke()
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
  clearCanvas(canvas: HTMLCanvasElement) {
    var ctx = this.getCtx(canvas)
    ctx.clearRect(0, 0, canvas.width, canvas.height)
    ctx.stroke()
  }
  //=====================================================================

  getCtx(canvas: HTMLCanvasElement): CanvasRenderingContext2D {
    var ctx = canvas.getContext('2d');
    ctx.lineCap = 'round';
    ctx.strokeStyle = '#000'
    ctx.beginPath()
    return ctx;
  }
  intialScreen() {
    this.freeDrawCanvasRef.nativeElement.width = this.freeDrawCanvasRef.nativeElement.offsetWidth;
    this.freeDrawCanvasRef.nativeElement.height = this.freeDrawCanvasRef.nativeElement.offsetHeight;
    this.canvasShapeRef.nativeElement.width = this.canvasShapeRef.nativeElement.offsetWidth;
    this.canvasShapeRef.nativeElement.height = this.canvasShapeRef.nativeElement.offsetHeight;
    this.localScreen = new Point(this.freeDrawCanvasRef.nativeElement.width, this.freeDrawCanvasRef.nativeElement.height);
  }
  clearMarkers() {
    var docId = this.doc.docId;
    this.drawingService.clearMarkers(docId);
  }
  onRect() {
    this.drawingService.setMode('Rectangle')
  }
  onEllipse() {
    this.drawingService.setMode('Ellipse')
  }

}
