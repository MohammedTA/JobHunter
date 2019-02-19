import { Component, OnInit } from '@angular/core';
import { Category } from '../../models/category';
import { CATEGORIES } from '../../models/mock-categories';
//import { filterModel } from '../../models/CategoryList';
//import { CategoryListModel, FilterModel } from '../../interfaces/categoryListInterfaces';
//import { CategoryService } from '../../services/category.service';
//import { Router } from '@angular/router';

@Component({
  selector: 'app-categories-list',
  templateUrl: './categories-list.component.html',
  styleUrls: ['./categories-list.component.css']
  
})
export class CategoriesListComponent implements OnInit {
  categories = CATEGORIES;

  /*
  category: Category = {
    id: 1,
    name: 'IT'
  };
  */
  
  constructor() { }

  ngOnInit() {
    console.log(this.categories);
  }
}

/*
 import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-categories-list',
  templateUrl: './categories-list.component.html',
  styleUrls: ['./categories-list.component.css']

})
export class CategoriesListComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

}
*/
