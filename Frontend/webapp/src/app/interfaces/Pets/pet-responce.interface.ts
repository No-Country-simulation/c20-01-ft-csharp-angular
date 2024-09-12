import { Pet } from './pet.interface';

export interface PetResponce {
  isSuccess: boolean;
  data: Pet;
  message: string;
}
