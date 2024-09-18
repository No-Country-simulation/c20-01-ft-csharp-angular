import { Component } from '@angular/core';
import { NavbarComponent } from '../../shared/navbar/navbar.component';
import { FooterComponent } from '../../shared/footer/footer.component';
import { ActivatedRoute, Router, RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [RouterModule, CommonModule],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css',
})
export class HomeComponent {
  public isChildRouteActive = false;

  constructor(private router: Router, private activatedRoute: ActivatedRoute) {
    // Detectar si hay rutas hijas activas
    this.router.events.subscribe(() => {
      this.isChildRouteActive = this.activatedRoute.firstChild !== null;
    });
  }
}
