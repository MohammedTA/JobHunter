import { FilterModel } from '../interfaces/vacancyListInterfaces';


export const filterModel:FilterModel={
    query:'',
    city:'',
    gender:{
      male:false,
      female:false,
      transgender:false
    },
    language:{
      without:false,
      beginer:false,
      elementary:false,
      intermediate:false,
      advanced:false
    },
     experience:'',
    accomodation:{
      without:false,
      free:false,
      paid:false
    },
    vacancyCost:0,
    visa:{
      on:false,
      off:false
  },
  currentPage: 1,
};
