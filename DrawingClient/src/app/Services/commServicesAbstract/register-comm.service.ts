import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { RegisterRequest } from 'src/app/DTO/Requests/register-request';
import { Response } from 'src/app/DTO/Responses/Response';

@Injectable({
  providedIn: 'root'
})
export abstract class RegisterCommService {

  abstract register(request: RegisterRequest): Observable<Response>;
}
