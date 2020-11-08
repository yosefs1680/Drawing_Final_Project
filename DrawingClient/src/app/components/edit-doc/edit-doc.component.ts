import { FormControl, Validators } from '@angular/forms';
import { EditDocService } from '../../Services/componentServices/edit-doc.service';
import { Document } from '../../DTO/Data/Document';
import { DrawingComponent } from '../drawing/drawing.component';
import { Component, OnInit, AfterViewInit, ViewChild, Inject, Input, ElementRef } from '@angular/core';
import { fromEvent } from 'rxjs';
import { switchMap, takeUntil, pairwise, map, buffer } from 'rxjs/operators';
import { Point } from 'src/app/DTO/Data/point';
import { MarkerService } from '../../Services/componentServices/marker.service';
import { DrawingService } from 'src/app/Services/componentServices/drawing.service';
import { DocsService } from 'src/app/Services/componentServices/docs.service';
import { ActivatedRoute } from '@angular/router';
import { MarkerData } from 'src/app/DTO/Data/markerData';


@Component({
  selector: 'app-edit-doc',
  templateUrl: './edit-doc.component.html',
  styleUrls: ['./edit-doc.component.css'],
  providers: [MarkerService, EditDocService]
})
export class EditDocComponent implements OnInit, AfterViewInit {

  @ViewChild('fcolor') fcolor: ElementRef
  @ViewChild('bcolor') bcolor: ElementRef
  @ViewChild('Drawing', { static: true }) drawingComponent: DrawingComponent;

  doc: Document
  markerList: Array<MarkerData>
  originScreen: Point;
  msg: string;

  constructor(
    private editDocService: EditDocService,
    private drawingService: DrawingService,
    private markerService: MarkerService,
    private docsService: DocsService,
    private route: ActivatedRoute,
  ) { }

  ngOnInit(): void {
    var docId = this.route.snapshot.paramMap.get('docId')
    this.editDocService.docId = docId

    this.docsService.getDoc(docId)
      .subscribe(res => {
        this.doc = res.data
      });

    this.markerService.getAllMarkersByDocId(docId);
    this.markerService.onGetAllMarkersOk.subscribe(res => {
      this.markerList = res.data;
      this.markerList.forEach(elmt => {
        if (elmt.markerType == 'Rectangle') {
          this.drawingService.drawRect(elmt)
          //OR: this.drawingService.DrawingSubject['Rectangle'].next(elmt.marker)
          //OR: this.drawingService.onDrawRectangle.next(elmt.marker)
        }
        if (elmt.markerType == 'Ellipse') {
          this.drawingService.drawEllipse(elmt)
        }
      })
    })
  } // ngOnInit

  getDoc(docId: string) {
    this.docsService.getDoc(docId)
      .subscribe(res => {
        console.log(res)
        this.doc = res.data
      });
  } 

  ngAfterViewInit(): void {
    fromEvent(this.fcolor.nativeElement, 'change')
      .subscribe((v: any) => this.editDocService.fColor = v.target.value)
    fromEvent(this.bcolor.nativeElement, 'change')
      .subscribe((v: any) => this.editDocService.bColor = v.target.value)

    var canvasEl = this.drawingComponent.freeDrawCanvasRef.nativeElement
    this.editDocService.mouseEvtListening(canvasEl)

  }

  onEllipse() {
    this.editDocService.setMode('Ellipse')
  }
  onRect() {
    this.editDocService.setMode('Rectangle')
  }
  clearMarkers() {
    this.editDocService.clearMarkers(this.doc.docId)
  }
}
