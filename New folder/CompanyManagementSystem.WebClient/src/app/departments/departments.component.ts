import { Component, OnInit } from '@angular/core';

import { DepartmentsService } from './departments.service';

@Component({
  selector: 'app-departments',
  templateUrl: './departments.component.html',
  styleUrls: ['./departments.component.css']
})
export class DepartmentsComponent implements OnInit {
  departments = [];

  constructor(private departmentsService: DepartmentsService) { }

  ngOnInit() {
    this.departmentsService
      .getDepartments()
      .then(departments => this.departments = departments);
  }

}
