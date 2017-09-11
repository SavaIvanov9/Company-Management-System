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
    const id = this.getTeamId();
    this.getTeamById(id);
    this.getEmployees(id);
  }

  private getTeamById(id: number): void {
    this.teamService.getTeamById(id)
      .subscribe((team: Team) => {
        this.team = team;
      });
  }

  private getEmployees(id: number): void {
    this.teamService.getEmployeesByTeamId(id)
      .subscribe((result: User[]) => {
        this.users = result;
      });
  }

  private getTeamId(): number {
    return this.activatedRoute.snapshot.params['id'];
  }
}
