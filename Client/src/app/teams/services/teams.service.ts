import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Rx';
import { Http, Response, Headers } from '@angular/http';
import 'rxjs/add/operator/map';

import { DomainUrl } from '../../shared/constants';

import { HttpClient } from '../../core/services/http-client';
import { Team } from '../models/team.model';
import { User } from '../../profile/models/user.model';
import { TeamCreateModel } from '../models/teamCreate.model';

@Injectable()
export class TeamsService {

  private teamUrl: string = DomainUrl + 'api/Team';
  private GetEmployeesByTeamIdUrl: string =  DomainUrl + 'api/Employee/GetEmployeesByTeam?Id=';

  constructor(private http: HttpClient) {
  }

  public getTeams(): Observable<Team[]> {
    return this.http.get(this.teamUrl)
      .map((res: Response) => res.json());
  }

  public getTeamById(id: number): Observable<Team> {
    return this.http.get(this.teamUrl + `/${id}`)
      .map((res: Response) => res.json());
  }

  public getEmployeesByTeamId(id: number): Observable<User[]> {
    return this.http.get(this.GetEmployeesByTeamIdUrl + `${id}`)
      .map((res: Response) => res.json());
  }

  public createTeam(teamCreateModel: TeamCreateModel) {
    return this.http.post(this.teamUrl, teamCreateModel)
      .map((res: Response) => res.json());
  }
}
