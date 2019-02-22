import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { HotVacanciesComponent } from './hot-vacancies.component';

describe('HotVacanciesComponent', () => {
  let component: HotVacanciesComponent;
  let fixture: ComponentFixture<HotVacanciesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ HotVacanciesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(HotVacanciesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
