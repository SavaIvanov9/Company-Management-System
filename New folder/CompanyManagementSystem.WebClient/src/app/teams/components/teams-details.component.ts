import { ActivatedRoute, ParamMap } from '@angular/router';
import { Component, OnInit } from '@angular/core';

import { TeamsService } from '../services/teams.service';

import { Team } from '../models/team.model';
import { User } from '../../profile/models/user.model';

@Component({
  selector: 'app-teams-details',
  templateUrl: './teams-details.component.html',
  styleUrls: ['./teams-details.component.css']
})

export class TeamsDetailsComponent implements OnInit {

  private team: Team = new Team();
  private users = [];

  constructor(private teamService: TeamsService,
    private activatedRoute: ActivatedRoute) { }

  ngOnInit() {
    let id = this.GetTeamId();
    this.GetTeamById(id);
    this.GetEmployees(id);
  }

  private GetTeamById(id: number): void {
    this.teamService.GetTeamById(id)
      .subscribe((team: Team) => {
        this.team = team;
      });
  }

  private GetEmployees(id: number): void {
    this.teamService.GetEmployeesByTeamId(id)
      .subscribe((result: User[]) => {
        console.log(result);
        this.users = result;
        console.log(this.users)
      });
  }

  private GetTeamId(): number {
    return this.activatedRoute.snapshot.params['id'];
  }
}
