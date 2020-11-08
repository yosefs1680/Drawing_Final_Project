import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { LoginService } from 'src/app/Services/componentServices/login.service';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  LoginForm: FormGroup
  message: string
 
  constructor(private loginService: LoginService, private router: Router) { }

  ngOnInit(): void {
    this.LoginForm = new FormGroup({
      userEmail: new FormControl('', [Validators.required, Validators.email]),
     
    })

    this.loginService.onLoginOk.subscribe(res => this.loginNav('my-documents'))
    this.loginService.onLoginInValid.subscribe(res => this.message=res.Message())
  }

  onSubmit(): void {
    this.loginService.login(this.LoginForm.value)
  }

  loginNav(path: string) {
    localStorage.setItem('login', 'true');
    localStorage.setItem('userId', this.LoginForm.value.userEmail)
    this.router.navigate([path])
  }
}
