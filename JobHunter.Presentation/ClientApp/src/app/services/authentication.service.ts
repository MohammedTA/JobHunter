import { environment } from '../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { JwtHelperService } from '@auth0/angular-jwt';
import { User } from '../models/User';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {
  private baseUrl = environment.apiUrl + 'auth/';
  private jwtHelper = new JwtHelperService();
  decodedToken: any;

  constructor(private http: HttpClient) { }

  login(user: User) {
    return this.http.post(this.baseUrl + 'login', user)
      .pipe(
        map((response: any) => {
          const res = response;
          if (user) {
            localStorage.setItem('token', res.token);
            this.decodedToken = this.jwtHelper.decodeToken(res.token);
          }
        })
      );
  }

  loginWithFacebook(token: any) {
    return this.http.post(this.baseUrl + 'fblogin', token)
      .pipe(
        map((response: any) => {
          const res = response;
          if (token) {
            localStorage.setItem('token', res.token);
            this.decodedToken = this.jwtHelper.decodeToken(res.token);
          }
        })
      );
  }

  loggedIn() {
    const token = localStorage.getItem('token');
    return !this.jwtHelper.isTokenExpired(token);
  }

  loggedInFB() {
    const FBtoken = localStorage.getItem('token');
    return !this.jwtHelper.isTokenExpired(FBtoken);
  }

}
