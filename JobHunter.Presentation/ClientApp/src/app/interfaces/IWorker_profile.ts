export interface IWorkerProfile {
  surname: string;
  name: string;
  middlename: string;
  password: string;
  confirm_password: string;
  contacts: IContacts;
}

export interface IContacts {
  phones: string[];
  viber: string;
  telegram: string;
  skype: string;
  whats_up: string;
}



export interface IErrors {
  phone: string;
  surname: string;
  name: string;
  middlename: string;
  password: string;
  confirm_password: string;
}