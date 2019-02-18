import { filterModel } from '../../models/FilterModel';
import { FilterModel, PaginatedVacancyList } from '../../interfaces/vacancyListInterfaces';
import { VacancyService } from '../../services/vacancy.service';
import { PaginationService } from '../../services/pagination.service';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-vacancy-list',
  templateUrl: './vacancy-list.component.html',
  styleUrls: ['./vacancy-list.component.css']
})
export class VacancyListComponent implements OnInit {
  paginatedVacancyList: PaginatedVacancyList;
  filters: FilterModel;
  isFiltersVisible:boolean=false;
  pager: any = {};
  private paginationservice:PaginationService=new PaginationService();
  pagedItems: any[];
  constructor(private router: Router, private vacancyservice:VacancyService) { 
    this.filters = filterModel;
  }
  ngOnInit() {
    this.vacancyservice.getVacanciesList(this.filters).subscribe(result => {
      this.paginatedVacancyList = result;
      this.setPage(this.paginatedVacancyList.pageInfo.currentPage);
    }, error => console.log(error));
    
    //this.vacancyservice.getVacancies(this.filters).subscribe(result => {
    //  this.vacancies = result;
    //}, error => console.error(error));
  //  this.vacancies=[
  //  {id:1, title:'vacancy1',description:'dfdfdfdfdf', date:new Date().toLocaleDateString(),companyTitle:'SoftServe', vacancyCity:'Lviv', isHot:true, isVip:false,  logo:'', vacancyCost:''},
  //    { id: 1, title: 'vacancy1', description: 'dfdfdfdfdf', date: new Date().toLocaleDateString(), companyTitle: 'HoneyCombSoft', vacancyCity: 'Rivne', isHot: true, isVip: false, logo: '', vacancyCost: '500'},
  //    { id: 1, title: 'vacancy1', description: 'dfdfdfdfdf', date: new Date().toLocaleDateString(), companyTitle: 'AB Games', vacancyCity: 'Rivne', isHot: false, isVip: false, logo: '', vacancyCost: '100'},
  //    { id: 1, title: 'vacancy1', description: 'dfdfdfdfdf', date: new Date().toLocaleDateString(), companyTitle: 'Wargaming', vacancyCity: 'Kyiv', isHot: false, isVip: false, logo: '', vacancyCost: '300'}
  //]
  }
  private setPage(page: number) {
    if (page < 1 || page > this.pager.totalPages) {
        return;
    }
    //this.pageModel.currentPage = page;
    this.filters.currentPage = page;
    this.vacancyservice.getVacanciesList(this.filters).subscribe(result => {
    this.paginatedVacancyList = result;
    this.pager = this.paginationservice.getPager(this.paginatedVacancyList.pageInfo.totalItems, this.paginatedVacancyList.pageInfo.currentPage,
    this.paginatedVacancyList.pageInfo.itemsPerPage, this.paginatedVacancyList.pageInfo.totalPages);
  }, error => console.error(error));
  }
  private ToggleFiltersVisibility(){
    this.isFiltersVisible=!this.isFiltersVisible;
  }
  private onSearchClick = () => {
    this.filters.currentPage = 1;
    this.vacancyservice.getVacancies(this.filters).subscribe(result => {
      this.paginatedVacancyList = result;
      this.pager = this.paginationservice.getPager(this.paginatedVacancyList.pageInfo.totalItems, this.paginatedVacancyList.pageInfo.currentPage,
      this.paginatedVacancyList.pageInfo.itemsPerPage, this.paginatedVacancyList.pageInfo.totalPages);
  }, error => console.error(error));};
 // console.log(this.filters); this.router.navigate( ['/jobs'],  { queryParams:this.filters})
}
