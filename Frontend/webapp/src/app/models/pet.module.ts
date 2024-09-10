export interface Pet {
  petId: string;
  petName: string;
  petSpecie: string;
  petAge: number;
  description: string;
  created: Date;

  adoptionId?: string;
}
