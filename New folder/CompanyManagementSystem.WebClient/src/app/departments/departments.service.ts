import { Injectable } from '@angular/core';
import {Observable} from 'rxjs/Rx';
import { Http, Response, Headers } from '@angular/http';

import { HttpClient } from '../core/services/http-client'
import { Department } from './models/department.model'

import { DomainUrl } from '../shared/constants';

@Injectable()
export class DepartmentsService {

  private getDepartmentsUrl: string = DomainUrl + 'api/department';
  //private http: HttpClient = new HttpClient();

  constructor(private http: HttpClient) {
  }

  departments = [
    {
      name: 'R&D',
      id: 0,
      teams: [{ name: 'Team Blue', id: 0 }],
      description: 'Deep Software understanding, engineering, formulating, developing and delivering protein-based treatments.',
      manager: 'Georgi Hristov'
    },
    {
      name: 'HR',
      id: 1,
      teams: [{ name: 'Team Red', id: 1 }],
      description: ''
    },
  ];

  //   getDepartments() {
  //     return Promise.resolve(this.departments);
  //   }

  public getDepartments(): Observable<Department[]> {
    return this.http.get(this.getDepartmentsUrl)
      .map((res: Response) => res.json())
  }

  //   public getAllUsers(): Observable<User[]> {
  //   return this.http.get(this.getAllUsersUrl)
  //     .map((res: Response) => res.json())
  //     .catch(error => this.errorHandler.handleError(error));
  // }

  public getDepartmentById(id) {
    return Promise.resolve(this.departments[id]);
  }
}
