export interface IEmployerProfile {
  ID: string;
  companyName: string;
  contactPerson: IContactPerson;
  type: IEmployerType;
  contacts: IContacts;
  logo: string;
  site: string;
  country: string;
  town: string;
  adress: string;
  description: string;
  password: string;
  INN: string;
  EGRPOU: string;
}

export interface IContactPerson {
  contactPersonName: string;
  contactPersonSurname: string;
  contactPersonMiddleName: string;
}

export interface IEmployerType {
  directEmployer: boolean;
  intermediary: boolean;
  agency: boolean;
}

export interface IContacts {
  telephone: { number: string }[];
  viber: string;
  telegram: string;
  whatsapp: string;
  email: string
}




