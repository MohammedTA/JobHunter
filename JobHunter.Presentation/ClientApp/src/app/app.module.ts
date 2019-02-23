import { HeaderComponent } from './components/Layout/header/header.component';
import { LoginComponent } from './components/auth/login/login.component';
import { ProfileComponent } from './components/profile/profile.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { FacebookLoginProvider, AuthServiceConfig, SocialLoginModule } from 'angularx-social-login';
import { AppComponent } from './app.component';
import { AuthenticationService } from './services/authentication.service';
import { ErrorInterceptorProvider } from './services/error.interceptor';
import { AuthGuard } from './_guards/auth.guard';
import { JwtModule } from '@auth0/angular-jwt';
import { AlertifyService } from './services/alertify.service';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { appRoutes } from './route.routing';
import { SpinnerComponent } from './components/spinner/spinner.component';
import { HomeComponent } from './components/home/home.component';

import { FooterComponent } from './components/Layout/footer/footer.component';
import { HotVacanciesComponent } from './components/hot-vacancies/hot-vacancies.component';
import { CompaniesListComponent } from './components/home/companies-list/companies-list.component';
import { EmployerProfileComponent } from './employer-profile/employer-profile.component';
import { VacancyListComponent } from './components/vacancy-list/vacancy-list.component';

const config = new AuthServiceConfig([
  {
    id: FacebookLoginProvider.PROVIDER_ID,
    provider: new FacebookLoginProvider('1363750207097183')
  },
]);

export function provideConfig() {
  return config;
}

export function tokenGetter() {
  return localStorage.getItem('token');
}

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    HotVacanciesComponent,
    CompaniesListComponent,
    HomeComponent,
    ProfileComponent,
    LoginComponent,
    SpinnerComponent,
    HeaderComponent,
    EmployerProfileComponent,
    VacancyListComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    SocialLoginModule,
    RouterModule.forRoot(appRoutes),
    JwtModule.forRoot({
       config: {
         tokenGetter: tokenGetter,
         whitelistedDomains: ['localhost:5001'],
         blacklistedRoutes: ['localhost:5001/api/auth']
       }
     })
  ],
  providers: [
    AuthenticationService,
    ErrorInterceptorProvider,
    AlertifyService,
    AuthGuard,
    {
      provide: AuthServiceConfig,
      useFactory: provideConfig
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
