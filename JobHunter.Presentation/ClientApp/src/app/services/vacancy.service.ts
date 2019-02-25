import {
    FilterModel,
    PaginatedVacancyList,
    FilterEndPoints
} from '../interfaces/vacancyListInterfaces';
import { filterEndPoints } from '../models/FilterModel';
import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class VacancyService {
  filterEndPoints = null;
  VACANCIES_API = this.baseUrl + 'api/Vacancy/';
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  getVacanciesList(params: FilterModel/*pagemodel: PageModel*/) {
    return this.http.post<PaginatedVacancyList>(this.VACANCIES_API + 'GetVacancies', params);
  }
  getFilterEndPoints() {
      return this.http.get<FilterEndPoints>(this.VACANCIES_API + 'GetFilterEndPoints');
  }
}
