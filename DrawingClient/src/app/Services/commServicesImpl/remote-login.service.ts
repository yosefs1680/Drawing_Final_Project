import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { LoginRequest } from '../../DTO/Requests/login-request';
import { LoginCommService } from '../commServicesAbstract/login-comm.service';
import { Response } from '../../DTO/Responses/Response';

@Injectable({
  providedIn: 'root'
})
export class RemoteLoginService implements LoginCommService {

  constructor(private httpClient : HttpClient) { }

 public login(request : LoginRequest) : Observable<Response> {
    return this.httpClient.post<Response>
    ("api/LoginCtrl", request);
  }
}
