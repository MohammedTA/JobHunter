import { Component, OnInit } from '@angular/core';
import { Vacancies } from '../../mocks/mock-hot-vacancy';

@Component({
  selector: 'app-hot-vacancies',
  templateUrl: './hot-vacancies.component.html',
  styleUrls: ['./hot-vacancies.component.css']
})
export class HotVacanciesComponent implements OnInit {

  hotVacancies = Vacancies;
  constructor() { }

  ngOnInit() {
  }

}
