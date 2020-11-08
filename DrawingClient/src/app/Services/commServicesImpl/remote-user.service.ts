import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from 'src/app/DTO/Data/user';
import { UserCommService } from '../commServicesAbstract/user-comm.service';
import { Response } from 'src/app/DTO/Responses/Response';

@Injectable({
  providedIn: 'root'
})
export class RemoteUserService implements UserCommService{
  constructor(private httpClient: HttpClient) { }

  // public getAllUsers(): Observable<Response> {
  //   return this.httpClient.post<Response>("api/getAllUsers")
  // }
}
