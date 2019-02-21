import { IEmployerProfile } from '../interfaces/employerProfileInterface';
import { EmployerProfile } from '../models/EmployerProfile';
import { Injectable, Inject, Component, OnInit } from '@angular/core';
import { HttpClient, HttpParams, HttpHeaders } from '@angular/common/http';

@Injectable()


export class EmployerProfileService {
  _employerProfile = new EmployerProfile();

  EmployerProfile_Url = 'api/' + 'employerprofile';

 constructor(private http: HttpClient) { };

  createProfile(_employerProfile: EmployerProfile) {
    
    return this.http.post(this.EmployerProfile_Url, _employerProfile);
  }
}



