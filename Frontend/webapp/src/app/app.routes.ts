import { Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { PetsListComponent } from './pages/pets-list/pets-list.component';
import { PetDetailComponent } from './pages/pet-detail/pet-detail.component';

export const routes: Routes = [
  {
    path: '',
    component: HomeComponent, // Main Page
    children: [
      {
        // Adopta una mascota
        path: 'home',
        component: PetsListComponent,
      },
      {
        // Detalles mascota
        path: 'detail/:id',
        component: PetDetailComponent,
      },
      /*
      -- Create UserComponent --
      {
      // crear nueva mascota (admin)
        path: 'new',
        component: UserComponent,
      },
      {
      // editar datos mascota (admin)
        path: 'edith/:id',
        component: UserComponent,
      }
       */
    ],
  },
  {
    path: '**', // If not found redirect to Home
    redirectTo: 'home',
    pathMatch: 'full', // Match the whole URL path
  },
];
