import { Injectable } from '@angular/core';

@Injectable()
export class EmployeesService {

  employees = [
    {
      id: 0,
      img: 'https://appstudio.windows.com/Content/img/temp/icon-user.png',
      name: 'Ivan Georgiev',
      position: 'Manager'
    },
    {
      id: 1,
      img: 'https://appstudio.windows.com/Content/img/temp/icon-user.png',
      name: 'Nikolai Ivanov',
      position: 'Software Developer'
    },
    {
      id: 2,
      img: 'https://appstudio.windows.com/Content/img/temp/icon-user.png',
      name: 'Neli Kalinova',
      position: 'Senior Software Developer'
    }
  ];

  getAllEmployeesByDeptId() {
    return Promise.resolve(this.employees);
  }

  
}
