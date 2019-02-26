import { FilterModel, FilterEndPoints } from '../../interfaces/vacancyListInterfaces';
import { Component, OnInit, Input } from '@angular/core';
import { VacancyService } from '../../services/vacancy.service';

@Component({
  selector: 'app-filter-component',
  templateUrl: './filter-component.component.html',
  styleUrls: ['./filter-component.component.css']
})
export class FilterComponentComponent implements OnInit {
  @Input() filters: FilterModel;
  filterEndPoints: FilterEndPoints;

  constructor(private vacancyservice: VacancyService) { }

  ngOnInit() {
    if (!this.filterEndPoints) {
      this.vacancyservice.getFilterEndPoints().subscribe(result => {
      this.filterEndPoints = result; console.log(this.filterEndPoints);
        this.filters.categories = result.categories.map(x => ({categoryName: x, isSelected: false}));
        this.filters.languageLevels = result.languageLevels.map(x => ({languageLevelName: x, isSelected: false}));
      },
        error => console.log(error)
      );
    }
  }
}
