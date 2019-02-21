import { Component, OnInit } from '@angular/core';
import {Companies} from '../../../mocks/mock-company'

@Component({
  selector: 'app-companies-list',
  templateUrl: './companies-list.component.html',
  styleUrls: ['./companies-list.component.css']
})
export class CompaniesListComponent implements OnInit {

  companies = Companies;
  constructor() { }

  ngOnInit() {
  }

}