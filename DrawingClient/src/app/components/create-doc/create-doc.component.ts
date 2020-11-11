import { DocsService } from 'src/app/Services/componentServices/docs.service';
import { Component, OnInit } from '@angular/core';
import { User } from '../../DTO/Data/user';
import { Route, Router } from '@angular/router';
import { Location } from '@angular/common';
import { FormGroup, FormControl, FormArray, FormBuilder, Validators } from '@angular/forms';
import { delay } from 'rxjs/operators';
import { Document } from 'src/app/DTO/Data/document';

@Component({
  selector: 'app-create-doc',
  templateUrl: './create-doc.component.html',
  styleUrls: ['./create-doc.component.css']
})

export class CreateDocComponent implements OnInit {

 
  doc: Document;

  documentForm: FormGroup;
  createDocResult: string = "";

  constructor(
    private route: Router,
    private docsService: DocsService,
    private location: Location,
  ) { }

  ngOnInit(): void {
    this.documentForm = new FormGroup(
      {
        docUrl: new FormControl(''),
        docName: new FormControl(''),
        owner: new FormControl(localStorage.getItem('userId')),
        docId: new FormControl(this.getUniqeId()),
      });

    // register to the any possible subject of AddContactResponse 
    this.docsService.onCreateDocOk.subscribe(async res => {
        this.createDocResult = res.data;
        setTimeout(() => {
          this.route.navigate(['edit/' + this.df.docId.value]);
        },
          3000);
      })

    this.docsService.onCreateDocErr
    .subscribe(res => {
      console.log (res)
      this.createDocResult = res.data;
    })
  }

  get df() {return this.documentForm.controls}

  onSubmit() {
    this.docsService.createDoc(this.documentForm.value);
  }
  goBack(): void {
    this.location.back();
  }
  private getUniqeId() {
    return Math.random().toString(36).substr(2, 9);
  }
}


