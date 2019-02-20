import { filterModel } from '../../models/FilterModel';
import { FilterModel, PaginatedVacancyList, PageInfo } from '../../interfaces/vacancyListInterfaces';
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
  private readonly DEFAULT_PAGE: number = 1;
  paginatedVacancyList: PaginatedVacancyList;
  filters: FilterModel = Object.assign({}, filterModel);
  searchParams: FilterModel = Object.assign({}, filterModel);
  isFiltersVisible = false;
  pageHelper: any = {};
  private paginationservice: PaginationService = new PaginationService();

  constructor(private router: Router, private vacancyservice: VacancyService) {
  }
  ngOnInit() {
    this.setPage();
  }
  private setPage(page: number = this.DEFAULT_PAGE) {
    if (page < 1 || page > this.pageHelper.totalPages) {
      return;
    }
    this.searchParams.currentPage = page;
    this.vacancyservice.getVacanciesList(this.searchParams).subscribe(result => {
      this.paginatedVacancyList = result;
      this.setPageHelper(this.paginatedVacancyList.pageInfo);
    }, error => console.error(error));
  }
  private ToggleFiltersVisibility() {
    this.isFiltersVisible = !this.isFiltersVisible;
  }
  private onSearchClick = () => {
    this.searchParams = Object.assign({}, this.filters);
    this.searchParams.currentPage = this.DEFAULT_PAGE;
    this.vacancyservice.getVacancies(this.searchParams).subscribe(result => {
      this.paginatedVacancyList = result;
      this.setPageHelper(this.paginatedVacancyList.pageInfo);
    }, error => console.error(error));
  }

  private setPageHelper = (pageinfo: PageInfo) => {
    this.pageHelper = this.paginationservice.getPager(pageinfo.totalItems, pageinfo.currentPage,
       pageinfo.itemsPerPage, pageinfo.totalPages);
  }
}
