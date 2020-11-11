import { Injectable } from '@angular/core';
import { Observable, Subject } from 'rxjs';
import { CreateDocRequest } from 'src/app/DTO/Requests/create-doc-request';
import { Response } from '../../DTO/Responses/Response'
import { DocsCommService } from '../commServicesAbstract/docs-comm.service';


@Injectable({
  providedIn: 'root'
})
export class DocsService {

  // create JSON dictionary { string : Subject } for recieve response:
  responseSubject = {
    CreateDocResponseErr: new Subject<any>(),
    CreateDocResponseOk: new Subject<any>(),
  }

  constructor(
    private docsCommService: DocsCommService,
  ) { }

  getAllDocs(userId: string): Observable<any> {
    return this.docsCommService.getAllDocs({ userId: userId });
  }

  getDoc(docId: string): Observable<any> {
    return this.docsCommService.getDoc({ docId: docId });
  }

  createDoc(value: any) {
    var request = {
      docData: {
        owner: value.owner,
        docId: value.docId,
        docUrl: value.docUrl,
        docName: value.docName,
      }
    }
    return this.docsCommService.createDoc(request)
      .subscribe(res => {
        this.responseSubject[res.responseType].next(res)
      });
  }

  get onCreateDocOk() {
    return this.responseSubject["CreateDocResponseOk"]
  }
  get onCreateDocErr() {
    return this.responseSubject["CreateDocResponseErr"]
  }

}