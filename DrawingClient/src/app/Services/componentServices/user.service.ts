import { Injectable } from '@angular/core';
import { LoginService } from './login.service';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private loginService: LoginService) {

    this.loginService.onLoginOk.
    subscribe(res => {
      this.userId = res.userId;
      this.userName = res.userName;
      this.isLoggedIn = true;
    })
  }

  userId: string = 'yosef@gmail.com';
  userName: string = undefined;
  isLoggedIn: boolean = false;
}
