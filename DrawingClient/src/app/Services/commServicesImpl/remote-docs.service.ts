import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { DocsCommService } from '../commServicesAbstract/docs-comm.service';
import { Response } from '../../DTO/Responses/Response'
import { GetDocRequest } from 'src/app/DTO/Requests/get-doc-request';
import { GetAllDocsRequest } from 'src/app/DTO/Requests/get-all-docs-request';

@Injectable({
  providedIn: 'root'
})
export class RemoteDocsService implements DocsCommService {

  constructor(private httpClient : HttpClient) { }

  public getAllDocs(request: GetAllDocsRequest): Observable<Response> {
    return this.httpClient.post<Response>
      ("api/GetAllMyDocsCtrl", request)
  }

  public getDoc(request: GetDocRequest): Observable<Response> {
    return this.httpClient.post<Response>
      ("api/GetDocCtrl", request);
  }
}
