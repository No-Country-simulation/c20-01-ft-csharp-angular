import { Pet } from './pet.interface';

export interface CreateResponce {
  isSuccess: boolean;
  data: Pet;
  message: string;
}
