import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Rx';
import 'rxjs/add/operator/map';
import { Http, Response, Headers } from '@angular/http';

import { HttpClient } from '../core/services/http-client';
import { Department } from './models/department.model';
import { Team } from '../teams/models/team.model';

import { DomainUrl } from '../shared/constants';

@Injectable()
export class DepartmentsService {

  private departmentsUrl: string = DomainUrl + 'api/department';
  private teamsUrl: string = DomainUrl + 'api/team';
  // private http: HttpClient = new HttpClient();

  constructor(private http: HttpClient) {
  }

  public getDepartments(): Observable<Department[]> {
    return this.http.get(this.departmentsUrl)
      .map((res: Response) => res.json());
  }

  public getTeamsByDepartment(id: number): Observable<Team[]> {
    return this.http.get(this.teamsUrl + `/GetByDepartment?departmentId=${id}`)
      .map((res: Response) => res.json());
  }

  public getDepartmentById(id): Observable<Department> {

    return this.http.get(this.departmentsUrl + `/${id}`)
      .map((res: Response) => res.json());
  }
}
