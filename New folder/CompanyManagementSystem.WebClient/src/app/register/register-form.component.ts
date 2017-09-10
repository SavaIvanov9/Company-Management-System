import { Component, EventEmitter, OnChanges, OnInit, Output } from '@angular/core';
import { FormArray, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';

import { ActivatedRoute } from '@angular/router';
import { Router } from '@angular/router';
import { Team } from './../teams/models/team.model';
import { TeamsService } from './../teams/services/teams.service';
import { UserCreateModel } from './models/userCreateModel';

@Component({
  selector: 'app-register-form',
  templateUrl: './register-form.component.html',
  styleUrls: ['./register-form.component.css']
})
export class RegisterFormComponent implements OnInit, OnChanges {

  constructor(private teamsService: TeamsService,
    private activatedRoute: ActivatedRoute,
    private router: Router,
    private fb: FormBuilder) { }

  registerForm;

  employee = {
    teams: []
  };


  allTeams = [];

  get teams(): FormArray {
    return this.registerForm.get('teams') as FormArray;
  }

  ngOnInit() {
    this.initFormGroup();
    this.loadTeams();
  }

  initFormGroup() {
    this.registerForm = new FormGroup({
      username: new FormControl(null, [Validators.required]),
      firstName: new FormControl(null, [Validators.required]),
      lastName: new FormControl(null, [Validators.required]),
      age: new FormControl(null, [Validators.required]),
      email: new FormControl(null, [Validators.required]),
      password: new FormControl(null, [Validators.required]),
      manager: new FormControl(null, [Validators.required]),
      position: new FormControl(null, [Validators.required]),
      teams: this.fb.array([]),
    });
  }

  private loadTeams() {
    this.teamsService
      .getTeams()
      .subscribe((result: Team[]) => {
        this.allTeams = result;
      });
  }

  private loadManagers() {
  }
  private loadPositions() {
  }

  onSubmit() {
    console.log(this.registerForm.value);
    console.log('submit');
    const data = new UserCreateModel();
    data.Username = this.registerForm.value.username;
    data.FirstName = this.registerForm.value.firstName;
    data.LastName = this.registerForm.value.lastName;
    data.Age = this.registerForm.value.age;
    data.Email = this.registerForm.value.email;
    data.Password = this.registerForm.value.password;
    data.ManagerId = this.registerForm.value.manager;
    data.PositionId = this.registerForm.value.position;
    data.TeamIds = this.registerForm.value.teams.map(e => e.id);
    console.log(data);
    // this.teamsService.createTeam(data).subscribe(() => this.ngOnInit());

  }
  onSelect() {

  }

  public ngOnChanges() {
    this.setTeams(this.employee.teams);
  }

  private setTeams(teams) {
    const teamsFGs = teams.map(team => this.fb.group(team));
    // const employeeFGs = employees.map(emp => emp.id);
    const teamsFormArray = this.fb.array(teamsFGs);
    this.registerForm.setControl('teams', teamsFormArray);
  }
  addPosition() {
    this.teams.push(this.fb.group({ id: '' }));
  }

  addManager() {
    // this.teams.push();
  }

  addTeam() {

  }


}
