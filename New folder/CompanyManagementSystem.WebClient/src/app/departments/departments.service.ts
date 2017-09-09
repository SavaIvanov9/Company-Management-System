import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Rx';
import 'rxjs/add/operator/map';
import { Http, Response, Headers } from '@angular/http';

import { HttpClient } from '../core/services/http-client';
import { Department } from './models/department.model';

import { DomainUrl } from '../shared/constants';

@Injectable()
export class DepartmentsService {

  private getDepartmentsUrl: string = DomainUrl + 'api/department';
  // private http: HttpClient = new HttpClient();

  constructor(private http: HttpClient) {
  }

  public getDepartments(): Observable<Department[]> {
<<<<<<< HEAD
    return this.http.Get(this.getDepartmentsUrl)
      .map((res: Response) => res.json());
=======
    return this.http.get(this.getDepartmentsUrl)
      .map((res: Response) => res.json())
>>>>>>> 1ca92b8e52444ce39527560b7fbbdd0c3491fccc
  }

  // public getDepartmentById(id) {
  //   return Promise.resolve(this.departments[id]);
  // }

  public getDepartmentById(id): Observable<Department> {
<<<<<<< HEAD
    return this.http.Get(this.getDepartmentsUrl + `/${id}`)
      .map((res: Response) => res.json());
=======
    return this.http.get(this.getDepartmentsUrl + `/${id}`)
      .map((res: Response) => res.json())
>>>>>>> 1ca92b8e52444ce39527560b7fbbdd0c3491fccc
  }
}
