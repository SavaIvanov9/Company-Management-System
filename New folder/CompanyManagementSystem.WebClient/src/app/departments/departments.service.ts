import { Injectable } from '@angular/core';

@Injectable()
export class DepartmentsService {

  departments = [
    {name : "R&D"},
    {name : "HR"}
  ]

  getDepartments() {
    return Promise.resolve(this.departments);
  }
}
