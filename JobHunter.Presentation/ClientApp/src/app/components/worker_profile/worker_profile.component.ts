import { Component, NgModule, Input } from '@angular/core';
import { WorkerProfileModel, Error } from '../../models/WorkerProfile'
import { HttpService } from '../../services/worker_profile.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-worker_profile',
  templateUrl: './worker_profile.component.html',
  styleUrls: ['./worker_profile.component.css'],
  providers: [HttpService]
})

export class WorkerProfileComponent {

  workerprofile = WorkerProfileModel;
  errors = Error;
  is_valid: boolean;
  constructor(private httpService: HttpService) { }

  AddPhone=()=>{
    //p[0].style.display = "block";
    console.log("In add phone");
  }
  validation = () => {
    this.is_valid = true;

    this.errors.surname = "";
    this.errors.name = "";
    this.errors.middlename = "";
    this.errors.phone = "";
    this.errors.password = "";
    this.errors.confirm_password = "";

    if (this.workerprofile.surname.length < 1) { this.errors.surname = "Input Surname"; this.is_valid = false; }
    if (this.workerprofile.name.length < 1) { this.errors.name = "Input Name"; is_valid: false; }
    if (this.workerprofile.middlename.length < 1) { this.errors.middlename = "Input Middlename"; this.is_valid = false; }
    if (this.workerprofile.contacts.phones[0].length != 10) { this.errors.phone = "Input at least 1 phone number with wright format"; this.is_valid = false; }
    if (this.workerprofile.password.length < 8) { this.errors.password = "Password must contain 8 symvols"; this.is_valid = false; }
    else if (this.workerprofile.password != this.workerprofile.confirm_password) { this.errors.confirm_password = "Confirm password not equal password"; this.is_valid = false; }
  };

  SendData = () => {
    this.validation();
    console.log(this.workerprofile);
    if (this.is_valid)
    {
      this.httpService.SetWorkerProfile(this.workerprofile).subscribe((res) => {
      //   console.log(res);   // new HttpService().SetWorkerProfile(this.workerprofile);
      });
    }
  }
}
