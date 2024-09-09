import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface Pet {
  petId: string;
  petName: string;
  petSpecies: string;
  petAge: number;
  description: string;
}

@Injectable({
  providedIn: 'root',
})
export class PetService {
  private apiUrl = 'https://localhost:7246/api/pets/all';

  constructor(private http: HttpClient) {}

  getPets(): Observable<Pet[]> {
    return this.http.get<Pet[]>(this.apiUrl);
  }
}
