import { LoginRequest } from '../../DTO/Requests/login-request';
import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';
import { LoginCommService } from '../commServicesAbstract/login-comm.service';
import { map } from 'rxjs/operators';
import { Login } from 'src/app/DTO/Data/login';


@Injectable({
  providedIn: 'root'
})
export class LoginService {

  ResponseSubjects: { [responseID: string]: Subject<any> } = {
    LoginResponseOk: new Subject<any>(),
    LoginResponseMailNotExist: new Subject<any>(),
  }

  constructor(private loginCommService : LoginCommService) { }

  login(value: any) {
   
    var loginRequest = new LoginRequest(new Login(value.userEmail));
    return this.loginCommService.login(loginRequest)
      .subscribe(res => this.ResponseSubjects[res.responseType].next(res))
    }

  get onLoginOk() { return this.ResponseSubjects['LoginResponseOk'] }
  get onLoginInValid() { return this.ResponseSubjects['LoginResponseMailNotExist'] }
}
