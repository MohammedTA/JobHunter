import { UserForLogin } from 'src/app/models/UserForLogin';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthenticationService } from 'src/app/services/authentication.service';
import { AlertifyService } from 'src/app/services/alertify.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  user: UserForLogin;
  private loggedIn: boolean;
  isRequesting: boolean;
  tokenFromFB: any = {};
  loginForm: FormGroup;

  constructor(
    private router: Router,
    private authService: AuthenticationService,
    private alertify: AlertifyService,
    private fb: FormBuilder
  ) {}

  ngOnInit() {
    this.createLoginForm();
  }

  createLoginForm() {
    this.loginForm = this.fb.group({
      input: ['', Validators.compose([Validators.required,
      Validators.pattern(/^([_a-z0-9]+(\.[_a-z0-9]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,5}))|(\d+$)$/)])],
      password: ['', [Validators.required, Validators.minLength(6), Validators.maxLength(12)]]
    });
  }

  login() {
    if (this.loginForm.valid) {
      this.isRequesting = true;
      this.user = Object.assign({}, this.loginForm.value);
      this.loginForm.disable();
      this.authService.login(this.user).subscribe(
        () => {
          this.isRequesting = false;
          this.alertify.success('Logged in successfully');
        },
        error => {
          this.isRequesting = false;
          this.alertify.error(error);
          this.loginForm.enable();
        },
        () => {
          this.isRequesting = false;
          this.router.navigate(['/profile']);
        }
      );
    }
  }

  cancel() {
    this.user = null;
    this.router.navigate(['/']);
  }
}
