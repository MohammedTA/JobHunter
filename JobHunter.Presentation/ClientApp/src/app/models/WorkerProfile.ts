import { IContacts, IWorkerProfile } from '../interfaces/IWorker_profile';

export const WorkerProfileModel : IWorkerProfile = {
    surname: '',
    name: '',
    middlename: '',
    password: '',
  confirm_password: '',
  contacts: {
    phones:
      [{ phone: '' }],
    viber: '',
    telegram: '',
    skype: '',
    whats_up: ''
  }
}
