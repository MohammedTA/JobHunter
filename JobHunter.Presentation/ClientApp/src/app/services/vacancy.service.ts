import { VacancyListModel, FilterModel, PaginatedVacancyList, PageModel } from '../interfaces/vacancyListInterfaces';
import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class VacancyService {
  VACANCIES_API = this.baseUrl + 'api/Vacancy/';
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  getVacancies(params: FilterModel){
    // query = this.VACANCIES_API + `\?city= ${params.city}`
    //                               + `&city=${params.city.split("&city=")}`
    //                               + `&gend` 
    return this.http.post<PaginatedVacancyList>(this.VACANCIES_API +'GetVacancies', params);
  }
  getVacanciesList(params: FilterModel/*pagemodel: PageModel*/) {
    return this.http.post<PaginatedVacancyList>(this.VACANCIES_API + 'GetVacancies', params);
    //let params = new HttpParams().set("currentPage", pagemodel.currentPage.toString()).set("pageSize", pagemodel.pageSize.toString());
    //return this.http.get<PaginatedVacancyList>(this.VACANCIES_API + 'GetVacanciesList', {params: params });
  }
}
