import { FilterModel, FilterEndPoints } from '../interfaces/vacancyListInterfaces';


export const filterModel: FilterModel =  {
    query: '',
  city: '',
  languageLevels: [],
  categories: [],
    gender: {
      male: false,
      female: false,
      other: false
    },
    language: {
      without: false,
      beginer: false,
      elementary: false,
      intermediate: false,
      advanced: false
    },
     experience: '',
    accomodation: {
      without: false,
      free: false,
      paid: false
    },
    vacancyCost: 0,
    visa: {
      on: false,
      off: false
  },
  currentPage: 1,
};

export const filterEndPoints: FilterEndPoints = {
  languageLevels: [],
  categories: [],
  experience: [],
  salaryMinValue: 0,
  salaryMaxValue: 0
};
