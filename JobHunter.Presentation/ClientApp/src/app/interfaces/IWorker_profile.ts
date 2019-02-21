export interface IWorkerProfile {
  surname: string;
  name: string;
  middlename: string;
  password: string;
  confirm_password: string;
  contacts: IContacts;
}

export interface IContacts {
  phones: IPhone[];
  viber: string;
  telegram: string;
  skype: string;
  whats_up: string;
}

export interface IPhone {
  phone: string;
}
