import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { HttpClientModule, HttpErrorResponse } from '@angular/common/http';
import { RouterOutlet } from '@angular/router';
import { PetService, Pet } from './services/pet.service';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet, HttpClientModule], // Importar HttpClientModule aquí
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  pets: Pet[] = [];

  constructor(private petService: PetService) {}

  ngOnInit() {
    this.petService.getPets().subscribe(
      (data: Pet[]) => {
        this.pets = data;
      },
      (error: HttpErrorResponse) => {
        console.error('Error al obtener las mascotas:', error.message);
      }
    );
  }
}
