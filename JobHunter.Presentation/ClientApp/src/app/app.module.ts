import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './components/nav-menu/nav-menu.component';
import { HomeComponent } from './components/home/home.component';
import { CounterComponent } from './components/counter/counter.component';
import { FetchDataComponent } from './components/fetch-data/fetch-data.component';

import { HeaderComponent } from './components/Layout/header/header.component';
import { FooterComponent } from './components/Layout/footer/footer.component';
import { HotVacanciesComponent } from './components/hot-vacancies/hot-vacancies.component';
import { CompaniesListComponent } from './components/home/companies-list/companies-list.component';
import { VacancyListComponent } from './components/vacancy-list/vacancy-list.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    HotVacanciesComponent,
    CompaniesListComponent,
    HomeComponent,
    VacancyListComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    NgbModule.forRoot(),
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'jobs', component: VacancyListComponent },
      { path: 'jobs/:id', component: VacancyListComponent },
 
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
