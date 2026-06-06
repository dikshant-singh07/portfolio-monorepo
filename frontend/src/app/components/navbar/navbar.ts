import { Component } from '@angular/core';
import { RouterLink, RouterLinkActive } from '@angular/router';

@Component({
  selector: 'app-navbar',
  standalone: true,
  imports: [RouterLink, RouterLinkActive], // <-- These enable instant navigation
  templateUrl: './navbar.html',
  styleUrl: './navbar.scss',
})
export class Navbar {}
