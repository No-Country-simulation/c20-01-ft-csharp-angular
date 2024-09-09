import { Component, OnInit } from '@angular/core';
import { PetsService } from './pets.service';
import { Pet } from './pet.model'; // Define el modelo según tu estructura

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    /* otros módulos */
  ],
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  pets: Pet[] = [];

  constructor(private petsService: PetsService) {}

  ngOnInit() {
    this.petsService.getPets().subscribe((data) => {
      this.pets = data;
    });
  }
}
