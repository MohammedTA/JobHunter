import { Component, OnInit } from "@angular/core";
import { SocialUser, AuthService, FacebookLoginProvider } from "angularx-social-login";
import { AuthenticationService } from "src/app/services/authentication.service";
import { Router } from "@angular/router";
import { AlertifyService } from "src/app/services/alertify.service";


@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent implements OnInit {
  model: any = {};
  tokenFromFB: any = {};
  private user: SocialUser;
  private FBloggedIn: boolean;

  constructor(private authService: AuthenticationService,
              private router: Router,
              private alertify: AlertifyService,
              private authFBservice: AuthService) {}

  ngOnInit() {
    this.authFBservice.authState.subscribe((user) => {
        this.user = user;
        this.FBloggedIn = (user != null);
        if (this.user !== null) {
          this.authService.loginWithFacebook(this.user).subscribe(() => {
            this.alertify.success('Login via Facebook');
          }, error => {
            this.alertify.error(error);
          }, () => {
            this.router.navigate(['/profile']);
          });
        }
      });
  }

  signInWithFB(): void {
    this.authFBservice.signIn(FacebookLoginProvider.PROVIDER_ID);
  }

  singOutFacebook() {
    this.authFBservice.signOut();
    this.FBloggedIn = false;
    localStorage.removeItem('token');
    this.alertify.message('Logged out via Facebook');
    this.router.navigate(['/']);
  }

  loggedIn() {
    return this.authService.loggedIn();
  }

  loggedInFB() {
    return this.FBloggedIn && localStorage.getItem('token');
  }

  logOut() {
    localStorage.removeItem('token');
    this.alertify.message('Logged out');
    this.router.navigate(['/']);
  }

}
