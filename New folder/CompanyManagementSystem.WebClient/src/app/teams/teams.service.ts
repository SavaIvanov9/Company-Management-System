import { Injectable } from '@angular/core';

@Injectable()
export class TeamsService {

  teams = [
    { name : "Team Blue", id : 0, employees : [
      {
        img: "src",
        name: "Ivan Georgiev",
        position: "Manager" 
      },
      {
        img: "src",
        name: "Nikolai Ivanov",
        position: "Software Developer" 
      },
      {
        img: "src",
        name: "Neli Kalinova",
        position: "Senior Software Developer" 
      }
    ]},
    { name : "Team Red", id : 1, employees : []}
  ]

  getTeams() {
    return Promise.resolve(this.teams);
  }

  getTeamById(id) {
    return Promise.resolve(this.teams[id]);
  }
}
