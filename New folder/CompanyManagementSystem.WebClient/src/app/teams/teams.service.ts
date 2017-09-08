import { Injectable } from '@angular/core';
import { Team } from './team.model';

@Injectable()
export class TeamsService {

  teams = [
    {
      name: 'Team Blue', id: 0, employees: [
        {
          id: 0,
          img: 'https://appstudio.windows.com/Content/img/temp/icon-user.png',
          name: 'Ivan Georgiev',
          position: 'Manager'
        },
        {
          id: 1,
          img: 'https://appstudio.windows.com/Content/img/temp/icon-user.png',
          name: 'Nikolai Ivanov',
          position: 'Software Developer'
        },
        {
          id: 2,
          img: 'https://appstudio.windows.com/Content/img/temp/icon-user.png',
          name: 'Neli Kalinova',
          position: 'Senior Software Developer'
        }
      ]
    },
    { name: 'Team Red', id: 1, employees: [] }
  ];

  getTeams() {
    return Promise.resolve(this.teams);
  }

  getTeamById(id) {
    return Promise.resolve(this.teams[id]);
  }
  createTeam(team) {
    team.id = this.teams.length;
    this.teams.push(team);
    return Promise.resolve(team);
  }
}
