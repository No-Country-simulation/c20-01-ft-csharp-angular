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

@Component({
  standalone: true,
  imports: [PetCardComponent, RouterModule],
  templateUrl: './pets-list.component.html',
  styleUrl: './pets-list.component.css',
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
        if (response.isSuccess) {
          this.pets.set(response.data);
          console.log('Pets fetched successfully:', response.data);
        }
      },
      (error) => {
        console.error('Error fetching pets', error);
      }
    );
  }
}
