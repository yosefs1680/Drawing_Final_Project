import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { LoginRequest } from '../../DTO/Requests/login-request';
import { Response } from '../../DTO/Responses/Response'

@Injectable({
  providedIn: 'root'
})
export abstract class LoginCommService {

 public abstract login(request: LoginRequest): Observable<Response>
}
