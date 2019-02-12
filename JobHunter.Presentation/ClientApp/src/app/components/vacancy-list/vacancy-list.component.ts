import { filterModel } from '../../models/VacancyList';
import { VacancyListModel, FilterModel } from '../../interfaces/vacancyListInterfaces';
import { VacancyService } from '../../services/vacancy.service';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-vacancy-list',
  templateUrl: './vacancy-list.component.html',
  styleUrls: ['./vacancy-list.component.css']
})
export class VacancyListComponent implements OnInit {
  vacancies:VacancyListModel[];
  filters:FilterModel;
  isFiltersVisible:boolean=true;
  constructor(private router: Router, private vacancyservice:VacancyService) { 
  this.filters=filterModel;
  }
  ngOnInit() {
    this.vacancyservice.getVacancies(this.filters).subscribe(result => {
      this.vacancies = result;
    }, error => console.error(error));
    this.vacancies=[
    {id:1, title:'vacancy1',description:'dfdfdfdfdf', date:new Date().toLocaleDateString(),companyTitle:'SoftServe', vacancyCity:'Lviv', vacancyType:'hot', logo:''},
    {id:1, title:'vacancy1',description:'dfdfdfdfdf', date:new Date().toLocaleDateString(), companyTitle:'HoneyCombSoft', vacancyCity:'Rivne', vacancyType:'hot',logo:''},
    {id:1, title:'vacancy1',description:'dfdfdfdfdf', date:new Date().toLocaleDateString(), companyTitle:'AB Games', vacancyCity:'Rivne', vacancyType:'hot',logo:''},
    {id:1, title:'vacancy1',description:'dfdfdfdfdf', date:new Date().toLocaleDateString(), companyTitle:'Wargaming', vacancyCity:'Kyiv', vacancyType:'hot',logo:''}
  ]
  }
  private ToggleFiltersVisibility(){
    this.isFiltersVisible=!this.isFiltersVisible;
  }
  private  onSearchClick=()=>{this.vacancyservice.getVacancies(this.filters).subscribe(result => {
    this.vacancies = result;
  }, error => console.error(error));};
 // console.log(this.filters); this.router.navigate( ['/jobs'],  { queryParams:this.filters})
}
