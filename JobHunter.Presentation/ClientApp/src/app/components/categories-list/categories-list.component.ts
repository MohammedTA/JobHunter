import { Component, OnInit } from '@angular/core';
import { Category } from '../../models/category';
import { CATEGORIES } from '../../models/mock-categories';

@Component({
  selector: 'app-categories-list',
  templateUrl: './categories-list.component.html',
  styleUrls: ['./categories-list.component.css']
})
export class CategoriesListComponent implements OnInit {
  categories = CATEGORIES;
  
  constructor() { }

  ngOnInit() {
  }
}