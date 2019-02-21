export interface VacancyListModel {
    id: number;
    title: string;
    description: string;
    date: string;
    logo: string;
    companyTitle: string;
    isHot: boolean;
    isVip: boolean;
    vacancyCity: string;
  vacancyCost: string;
  }
  export interface FilterModel {
    query: string;
    city: string;
    vacancyCost: number;
    gender: Gender;
    language: LanguageProficiency;
    experience: string;
    accomodation: Accomodation;
    visa: Visa;
    currentPage: number;
  }

  export interface Gender {
    male: boolean;
    female: boolean;
    transgender: boolean;
  }

  export interface LanguageProficiency {
    without: boolean;
    beginer: boolean;
    elementary: boolean;
    intermediate: boolean;
    advanced: boolean;
  }
  export interface Accomodation {
    without: boolean;
    free: boolean;
    paid: boolean;
  }
  export interface Visa {
    on: boolean;
    off: boolean;
}
export interface PageInfo {
  totalItems: number;
  itemsPerPage: number;
  currentPage: number;
  totalPages: number;
}
export interface PaginatedVacancyList {
  paginatedList: VacancyListModel[];
  pageInfo: PageInfo;
}
export interface PageModel {
  currentPage: number;
  pageSize: number;
}
