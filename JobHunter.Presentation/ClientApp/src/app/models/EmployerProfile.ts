import { IEmployerProfile, IContacts, IContactPerson, IEmployerType } from '../interfaces/employerProfileInterface';

export class EmployerProfile implements IEmployerProfile {
  ID = '';
  companyName = '';
  contactPerson: IContactPerson = {
    contactPersonName: '',
    contactPersonSurname: '',
    contactPersonMiddleName: ''
  };

  contacts: IContacts = {
    telephone: [{ number: '+38' }],
    viber: '',
    telegram: '',
    whatsapp: '',
    email: ''
  };

  type: IEmployerType = {
    directEmployer: false,
    intermediary: false,
    agency: false
  };

  logo: '';
  site: '';
  country: '';
  town: '';
  adress: '';
  description: '';
  password: '';
  INN: '';
  EGRPOU: '';
}
