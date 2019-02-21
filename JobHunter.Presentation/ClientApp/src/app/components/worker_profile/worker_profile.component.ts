import { Component, NgModule, Input } from '@angular/core';
import { WorkerProfileModel } from '../../models/WorkerProfile'
import { HttpService } from '../../services/worker_profile.service';
import { FormBuilder, FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-worker_profile',
  templateUrl: './worker_profile.component.html',
  styleUrls: ['./worker_profile.component.css'],
  providers: [HttpService]
})

export class WorkerProfileComponent {

  workerprofile = WorkerProfileModel;
  is_valid: boolean;
  constructor(private httpService: HttpService) { }

  Form = new FormGroup({
    'name': new FormControl(this.workerprofile.name, [
    Validators.required,
    Validators.minLength(1)
  ]),
 // 'alterEgo': new FormControl(this.hero.alterEgo),
 // 'power': new FormControl(this.hero.power, Validators.required)
});
  get name() { return this.Form.get('name'); }

  AddPhone = () => {
    if (this.workerprofile.contacts.phones.length < 5)
      this.workerprofile.contacts.phones.push({ phone: '' });
  }


  SendData = () => {
    console.log('----------Workerprofile----------',this.workerprofile);
    this.httpService.SetWorkerProfile(this.workerprofile).subscribe((res) => {
      console.log(res); 
    });
  }
}
