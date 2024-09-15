import { Component, inject, input } from '@angular/core';
import { Pet } from '../../interfaces';
import { PetService } from '../../services/pets/pet.service';

@Component({
  selector: 'app-pet-card',
  standalone: true,
  imports: [],
  templateUrl: './pet-card.component.html',
  styleUrl: './pet-card.component.css',
})
export class PetCardComponent {
  pet = input<Pet>();

  private _petsService = inject(PetService);
}
