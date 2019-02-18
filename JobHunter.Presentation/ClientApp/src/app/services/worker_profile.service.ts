import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IWorkerProfile } from '../interfaces/IWorker_profile'
@Injectable()
export class HttpService {
  VACANCIES_API = this.baseUrl + 'api/Worker/create-worker-profile/';
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  SetWorkerProfile(workerprofile: IWorkerProfile) {
    console.log(this.VACANCIES_API);
    return this.http.post(this.VACANCIES_API, workerprofile);
  }
}
