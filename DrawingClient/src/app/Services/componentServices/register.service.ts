import { Injectable } from '@angular/core';
import { Observable, Subject } from 'rxjs';
import { Login } from 'src/app/DTO/Data/login';
import { LoginRequest } from 'src/app/DTO/Requests/login-request';
import { RegisterRequest } from 'src/app/DTO/Requests/register-request';
import { RegisterCommService } from '../commServicesAbstract/register-comm.service';


@Injectable({
  providedIn: 'root'
})
export class RegisterService {

  constructor(private registerCommService: RegisterCommService) { }

  ResponseSubjects: { [responseType: string]: Subject<any> } = {
    RegisterResponseOk: new Subject<any>(),
    RegisterResponseUserExist: new Subject<any>(),
  }

  get onRegisterOk() { return this.ResponseSubjects['RegisterResponseOk'] }
  get onRegisterUserExist() { return this.ResponseSubjects['RegisterResponseUserExist'] }


  register(value: any) {
    // convert from FormControl to valid request
    var registerRequest = new RegisterRequest(value.userName, new Login(value.userEmail))
    return this.registerCommService.register(registerRequest)
      .subscribe(res => this.ResponseSubjects[res.responseType].next(res))
  }
}
