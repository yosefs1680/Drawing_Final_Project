import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { RegisterRequest } from 'src/app/DTO/Requests/register-request';
import { Response } from 'src/app/DTO/Responses/Response';
import { RegisterCommService } from '../commServicesAbstract/register-comm.service';

@Injectable({
  providedIn: 'root'
})
export class RemoteRegisterService implements RegisterCommService{

  constructor(private httpClient: HttpClient) { }

  register(request: RegisterRequest): Observable<Response> {
    console.log(request);
    return this.httpClient.post<Response>
      ("api/RegisterCtrl", request);
  }
  
}
