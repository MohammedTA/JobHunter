import { Component, OnInit } from '@angular/core';
import { IEmployerProfile } from '../interfaces/employerProfileInterface';
import { EmployerProfileService } from '../services/employerProfile.service';
import { Router } from '@angular/router';
import { EmployerProfile } from '../models/EmployerProfile';
import {Observable } from 'rxjs';
import { CurrencyPipe } from '@angular/common';



@Component({
  selector: 'app-employer-profile-component',
  templateUrl: './employer-profile.component.html',
  providers: [EmployerProfileService]
})

export class EmployerProfileComponent implements OnInit {
  public currentProfile = new EmployerProfile();
  public phones: {number: string}[] = [];

  constructor(private empProfileService: EmployerProfileService, private router: Router) {
  }

  ngOnInit(): void {
    this.phones = this.currentProfile.contacts.telephone;
  }
  
  addPhone() {
    this.phones.push({number:'+38'});
  }

  resetProfile() {
    this.currentProfile = new EmployerProfile();
  }

  createProfile() {
    this.currentProfile.contacts.telephone = this.phones;
    this.empProfileService.createProfile(this.currentProfile).subscribe(p => {
      Object.assign({p}, this.currentProfile);      
      
    }, err => {
      });
    console.log(this.currentProfile);
  }
}
