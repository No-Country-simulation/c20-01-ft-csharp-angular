import { CreateUpdate } from './create-update.interface';

export interface UpdateResponce {
  isSuccess: boolean;
  data: CreateUpdate;
  message: string;
}
