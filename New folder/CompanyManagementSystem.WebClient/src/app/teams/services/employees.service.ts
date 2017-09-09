import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Rx';
import { Http, Response, Headers } from '@angular/http';
import 'rxjs/add/operator/map';

import { DomainUrl } from '../../shared/constants';

import { HttpClient } from '../../core/services/http-client'
import { User } from '../../profile/models/user.model';

@Injectable()
export class EmployeesService {

  private GetEmployeesByDepartmentUrl: string = DomainUrl + 'api/Employee/GetEmployeesByDepartment?Id=';

  constructor(private http: HttpClient) {
  }

  public getAllEmployeesByDeptId(id: number): Observable<User[]> {
    return this.http.get(this.GetEmployeesByDepartmentUrl + `${id}`)
      .map((res: Response) => res.json());
  }
}
