import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from 'src/app/DTO/Data/user';
import { RegisterRequest } from 'src/app/DTO/Requests/register-request';
import { Response } from 'src/app/DTO/Responses/Response';

@Injectable({
  providedIn: 'root'
})
export abstract class UserCommService {

  constructor() { }

  //public abstract getAllUsers() : Observable<Response>;

}
