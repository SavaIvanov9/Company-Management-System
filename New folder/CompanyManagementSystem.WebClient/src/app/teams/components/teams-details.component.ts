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
<<<<<<< HEAD
<<<<<<< HEAD
    const id = this.GetTeamId();
    this.GetTeamById(id);
    this.GetEmployees(id);
=======
    let id = this.getTeamId();
    this.getTeamById(id);
    this.getEmployees(id);
>>>>>>> 1ca92b8e52444ce39527560b7fbbdd0c3491fccc
=======
    let id = this.getTeamId();
    this.getTeamById(id);
    this.getEmployees(id);
>>>>>>> 1ca92b8e52444ce39527560b7fbbdd0c3491fccc
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
<<<<<<< HEAD
<<<<<<< HEAD
        console.log(this.users);
=======
>>>>>>> 1ca92b8e52444ce39527560b7fbbdd0c3491fccc
=======
>>>>>>> 1ca92b8e52444ce39527560b7fbbdd0c3491fccc
      });
  }

  private getTeamId(): number {
    return this.activatedRoute.snapshot.params['id'];
  }
}
