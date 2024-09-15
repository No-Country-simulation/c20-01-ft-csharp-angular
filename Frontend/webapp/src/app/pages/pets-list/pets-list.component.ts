import {
  Component,
  inject,
  OnInit,
  signal,
  WritableSignal,
} from '@angular/core';
import { PetCardComponent } from '../../shared/pet-card/pet-card.component';
import { RouterModule } from '@angular/router';
import { PetService } from '../../services/pets/pet.service';
import { Pet } from '../../interfaces';
import { CommonModule } from '@angular/common';

@Component({
  standalone: true,
  imports: [CommonModule, PetCardComponent, RouterModule],
  templateUrl: './pets-list.component.html',
  styleUrls: ['./pets-list.component.css'],
})
export class PetsListComponent implements OnInit {
  ngOnInit() {
    this.getPets();
  }

  private _petsService = inject(PetService);
  public pets: WritableSignal<Pet[]> = signal([]);

  getPets() {
    this._petsService.getPets().subscribe(
      (response) => {
        if (Array.isArray(response)) {
          this.pets.set(response);
        } else {
          console.error('Unexpected response format:', response);
        }
      },
      (error) => {
        console.error('Error fetching pets', error);
      }
    );
  }

  trackByPetId(index: number, pet: Pet): string {
    return pet.petId;
  }
}
