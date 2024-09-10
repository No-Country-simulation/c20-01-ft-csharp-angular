export interface Adoption {
  adoptionId: string;
  adoptionDate: Date;
  adoptionStatus: string;

  userId?: string;
  petIds?: string[];
}
