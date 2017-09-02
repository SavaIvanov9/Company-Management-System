import { Injectable } from '@angular/core';

@Injectable()
export class DepartmentsService {

  departments = [
    {name : "R&D", id : 1},
    {name : "HR", id : 2}
  ]

  getDepartments() {
    return Promise.resolve(this.departments);
  }
}
