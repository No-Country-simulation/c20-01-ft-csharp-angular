export interface Pets {
  petId: string;
  petName: string;
  petSpecies: string;
  petAge: number;
  description: string;
  created: Date;

  adoptionId?: string;
}
