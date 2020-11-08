import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Response } from '../../DTO/Responses/Response'
import { DocsCommService } from '../commServicesAbstract/docs-comm.service';


@Injectable({
  providedIn: 'root'
})
export class DocsService {

  constructor(
    private docsCommService: DocsCommService,
  ) { }

  getAllDocs(userId: string): Observable<any> {
    return this.docsCommService.getAllDocs({userId: userId});
  }

  getDoc(docId: string) : Observable<any> {
    return this.docsCommService.getDoc({docId : docId});
  }
}