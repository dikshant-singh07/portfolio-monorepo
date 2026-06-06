import { Component, OnInit, inject } from '@angular/core';
import { ProjectService } from '../../services/project';
import { Project } from '../../models/project.model';

@Component({
  selector: 'app-project-list',
  standalone: true,
  templateUrl: './project-list.html',
  styleUrl: './project-list.scss'
})
export class ProjectListComponent implements OnInit {
  projects: Project[] = [];
  private projectService = inject(ProjectService);

  ngOnInit() {
    this.projectService.getProjects().subscribe({
      next: (data) => this.projects = data,
      error: (err) => console.error('Error fetching from .NET:', err)
    });
  }
}