import { Routes } from '@angular/router';
import { ProjectListComponent } from './components/project-list/project-list';
import { Contact } from './components/contact/contact';

export const routes: Routes = [
  { path: '', redirectTo: '/projects', pathMatch: 'full' }, 
  { path: 'projects', component: ProjectListComponent },
  { path: 'contact', component: Contact }
];