import { Pet } from './pet.interface';

export interface DeleteResponce {
  isSuccess: boolean;
  data: Pet;
  message: string;
}
