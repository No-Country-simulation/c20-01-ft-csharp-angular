export interface CreateUpdate {
  petId: string;
  petName: string;
  petSpecies: string;
  petAge: number;
  description: string;
  created: Date;

  adoptionId?: string;
}
