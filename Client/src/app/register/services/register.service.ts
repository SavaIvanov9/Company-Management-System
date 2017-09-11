import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Rx';
import { Http, Response, Headers } from '@angular/http';
import 'rxjs/add/operator/map';

import { DomainUrl } from '../../shared/constants';

import { HttpClient } from '../../core/services/http-client';
import { User as Manager } from '../../profile/models/user.model';
import { Position } from '../models/position.model';
import { UserCreateModel } from '../models/userCreateModel';

@Injectable()
export class RegisterService {

  private positionUrl: string = DomainUrl + 'api/Position';
  private employeeUrl: string = DomainUrl + 'api/Employee';
  private registerUrl: string = DomainUrl + 'api/Auth/Register';

  constructor(private http: HttpClient) {
  }

  public getPositions(): Observable<Position[]> {
    return this.http.get(this.positionUrl)
      .map((res: Response) => res.json());
  }

  public getManagers(): Observable<Manager[]> {
    return this.http.get(this.employeeUrl)
      .map((res: Response) => res.json());
  }

  public register(userCreateModel: UserCreateModel): Observable<any> {
    return this.http.post(this.registerUrl, userCreateModel)
      .map((res: Response) => res.json());
  }
}
