import { Pet } from './pet.interface';

export interface PetsResponce {
  isSuccess: boolean;
  data: Pet[];
  message: string;
}
