import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Rx';
import { Http, Response, Headers } from '@angular/http';
import 'rxjs/add/operator/map';

import { DomainUrl } from '../../shared/constants';

import { HttpClient } from '../../core/services/http-client'
import { Team } from '../models/team.model';
import { User } from '../../profile/models/user.model';

@Injectable()
export class TeamsService {

  private getTeamsUrl: string = DomainUrl + 'api/Team';
  private GetEmployeesByTeamIdUrl: string =  DomainUrl + 'api/Employee/GetEmployeesByTeam?Id=';

  constructor(private http: HttpClient) {
  }

  public getTeams(): Observable<Team[]> {
    return this.http.get(this.getTeamsUrl)
      .map((res: Response) => res.json());
  }

  public getTeamById(id: number): Observable<Team> {
    return this.http.get(this.getTeamsUrl + `/${id}`)
      .map((res: Response) => res.json());
  }

  public getEmployeesByTeamId(id: number): Observable<User[]> {
    return this.http.get(this.GetEmployeesByTeamIdUrl + `${id}`)
      .map((res: Response) => res.json());
  }

  createTeam(team) {
    // team.id = 1
    // this.teams.push(team);
    // return Promise.resolve(team);
  }
}
