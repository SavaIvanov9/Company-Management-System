import { ActivatedRoute, ParamMap } from '@angular/router';
import { Component, OnInit } from '@angular/core';

import { TeamsService } from './teams.service';

@Component({
  selector: 'app-teams-details',
  templateUrl: './teams-details.component.html',
  styleUrls: ['./teams-details.component.css']
})
export class TeamsDetailsComponent implements OnInit {
  team = {};
  employees = [];

  constructor(private teamsService: TeamsService,
    private activatedRoute: ActivatedRoute) { }

  ngOnInit() {
    const id = +this.activatedRoute.snapshot.params['id'];

    this.teamsService
      .getTeamById(id)
      .then(team => {
        this.team = team;
        this.employees = team.employees;
      }
      );

  }
}
