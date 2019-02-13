import { VacancyListModel, FilterModel } from '../interfaces/vacancyListInterfaces';
import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class VacancyService {
  VACANCIES_API=this.baseUrl+'api/Vacancy/GetVacancies';
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  getVacancies(params: FilterModel){
    // query = this.VACANCIES_API + `\?city= ${params.city}`
    //                               + `&city=${params.city.split("&city=")}`
    //                               + `&gend` 
   return this.http.post<VacancyListModel[]>(this.VACANCIES_API, params);
  }
    
}
