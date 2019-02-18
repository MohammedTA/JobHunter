import { IContacts, IWorkerProfile, IErrors } from '../interfaces/IWorker_profile';

export const WorkerProfileModel : IWorkerProfile = {
    surname: '',
    name: '',
    middlename: '',
    password: '',
  confirm_password: '',
  contacts: {
    phones: ['','','','',''],
    viber: '',
    telegram: '',
    skype: '',
    whats_up: ''
  }
}

export const Error : IErrors = {
  phone: '',
  surname: '',
  name: '',
  middlename: '',
  password: '',
  confirm_password: ''
}
