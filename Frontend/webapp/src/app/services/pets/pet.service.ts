import { inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import {
  CreateUpdate,
  DeleteResponce,
  PetsResponce,
  PetResponce,
  CreateResponce,
  UpdateResponce,
} from '../../interfaces';

@Injectable({
  providedIn: 'root',
})
export class PetService {
  private _baseUrl = 'http://localhost:5198';
  private http = inject(HttpClient);
  constructor() {}

  getPets(): Observable<PetsResponce> {
    return this.http.get<PetsResponce>(`${this._baseUrl}api/pets`);
  }

  getPet(id: string): Observable<PetResponce> {
    return this.http.get<PetResponce>(`${this._baseUrl}api/pets/${id}`);
  }

  postPet(newPet: CreateUpdate): Observable<CreateResponce> {
    return this.http.post<CreateResponce>(`${this._baseUrl}api/pets`, newPet);
  }

  putPet(petId: string, updatedPet: CreateUpdate): Observable<UpdateResponce> {
    return this.http.put<UpdateResponce>(
      `${this._baseUrl}api/pets/${petId}`,
      updatedPet
    );
  }

  deletePet(id: string): Observable<DeleteResponce> {
    return this.http.delete<DeleteResponce>(`${this._baseUrl}api/pets/${id}`);
  }
}
