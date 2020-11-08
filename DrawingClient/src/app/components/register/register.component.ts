import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { RegisterService } from 'src/app/Services/componentServices/register.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  RegisterForm: FormGroup
  message: string;

  constructor(
    private registerService: RegisterService,
    private router: Router) { }

  ngOnInit(): void {
    this.RegisterForm = new FormGroup({
      userEmail: new FormControl('', [Validators.required, Validators.email]),
      userName: new FormControl('', [Validators.required]),
    })

    this.registerService.onRegisterOk.subscribe(res => {
      console.log(res);
      this.router.navigate(['login'])
      this.message = res.responseMessage;
    });
    this.registerService.onRegisterUserExist.subscribe(res => {
      console.log(res);
      this.message = res.responseMessage;
    });
  }

  get formControls() { return this.RegisterForm.controls }
  get userName() { return this.formControls.userName }
  get userEmail() { return this.formControls.userEmail }

  login() {
    this.router.navigate(['login'])
  }

  onSubmit(): void {
    console.log(this.RegisterForm.value)
    this.registerService.register(this.RegisterForm.value)
  }
}
