import { Component, OnInit } from '@angular/core';

import { DepartmentsService } from './departments.service';

import { Department } from './models/department.model';

@Component({
  selector: 'app-departments',
  templateUrl: './departments.component.html',
  styleUrls: ['./departments.component.css']
})

export class DepartmentsComponent implements OnInit {
  private departments = [];

  constructor(private departmentsService: DepartmentsService) { }

  ngOnInit() {
    this.GetDepartments();
  }

  private GetDepartments(): void {
    this.departmentsService.getDepartments()
      .subscribe((departments: Department[]) => {
        this.departments = departments;
      });
  }
}
