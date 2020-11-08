import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { GetAllDocsRequest } from 'src/app/DTO/Requests/get-all-docs-request';
import { GetDocRequest } from 'src/app/DTO/Requests/get-doc-request';
import { Response } from '../../DTO/Responses/Response'

@Injectable({
  providedIn: 'root'
})
export abstract class DocsCommService {
  
  public abstract getAllDocs(request: GetAllDocsRequest): Observable<Response>;

  public abstract getDoc(request: GetDocRequest): Observable<Response>;
}
