import { Injectable } from '@angular/core';

@Injectable()
export class DepartmentsService {

  departments = [
    {
        name : 'R&D',
        id : 0,
        teams : [{ name : 'Team Blue', id : 0}],
        description: 'Deep Software understanding, engineering, formulating, developing and delivering protein-based treatments.',
        manager: 'Georgi Hristov'
    },
    {
      name : 'HR',
      id : 1,
      teams : [{ name : 'Team Red', id : 1}],
      description:''
  },
];

  getDepartments() {
    return Promise.resolve(this.departments);
  }

  getDepartmentById(id) {
    return Promise.resolve(this.departments[id]);
  }
}
