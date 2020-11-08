import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { DocsService } from 'src/app/Services/componentServices/docs.service';
import { Document } from '../../DTO/Data/document'

@Component({
  selector: 'app-docs-list',
  templateUrl: './docs-list.component.html',
  styleUrls: ['./docs-list.component.css']
})
export class DocsListComponent implements OnInit {

  constructor(private router:Router, private docsService: DocsService) { }

  // documentList: Array<Document> = new Array<Document>()
  documentList: Array<Document>
  @Input() userId: string = localStorage.getItem('userId')

  ngOnInit(): void {
    this.setDocsList()
  }

  ngOnChanges() {
    this.setDocsList()
  }
  AddContactBtn() {
    this.router.navigate(['register'])
  }

  setDocsList() {
    this.docsService.getAllDocs(this.userId).subscribe(
      res =>{      
        this.documentList = res.data
      }
    )   
  }
}
