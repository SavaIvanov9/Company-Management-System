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

  public GetTeams(): Observable<Team[]> {
    return this.http.Get(this.getTeamsUrl)
      .map((res: Response) => res.json());
  }

  public GetTeamById(id: number): Observable<Team> {
    return this.http.Get(this.getTeamsUrl + `/${id}`)
      .map((res: Response) => res.json());
  }

  public GetEmployeesByTeamId(id: number): Observable<User[]> {
    return this.http.Get(this.GetEmployeesByTeamIdUrl + `${id}`)
      .map((res: Response) => res.json());
  }

  CreateTeam(team) {
    // team.id = 1
    // this.teams.push(team);
    // return Promise.resolve(team);
  }
}
