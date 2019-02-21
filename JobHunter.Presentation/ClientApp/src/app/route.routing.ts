import { LoginComponent } from './components/auth/login/login.component';
import { AuthGuard } from './_guards/auth.guard';
import { ProfileComponent } from './components/profile/profile.component';
import { Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';

export const appRoutes: Routes = [
  { path: '', component: HomeComponent, pathMatch: 'full' },
  {
    path: '',
    runGuardsAndResolvers: 'always',
    canActivate: [AuthGuard],
    children: [
      { path: 'profile', component: ProfileComponent },
    ]
  },
  { path: 'sign-in', component: LoginComponent },
  // if somebody comes in a random root'
  { path: '**', redirectTo: '', pathMatch: 'full'}
];
