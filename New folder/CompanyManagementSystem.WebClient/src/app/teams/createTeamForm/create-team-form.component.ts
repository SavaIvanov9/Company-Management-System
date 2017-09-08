import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

import { ActivatedRoute } from '@angular/router';
import { EmployeesService } from './../employees.service'
import {Router} from '@angular/router';
import { Team } from './../team.model';
import { TeamsService } from './../teams.service';

@Component({
  selector: 'app-create-team-form',
  templateUrl: './create-team-form.component.html',
  styleUrls: ['./create-team-form.component.css']
})
export class CreateTeamFormComponent {

  constructor(private teamsService: TeamsService,
    private employeesService: EmployeesService,
    private activatedRoute: ActivatedRoute,
    private router: Router) { }

    teamForm

    employees = [];
    ngOnInit() {
      
      const id = +this.activatedRoute.snapshot.params['id'];
      this.teamForm = new FormGroup({
        
            departmentId: new FormControl(id),
            name:  new FormControl(null, [Validators.required, Validators.minLength(3), Validators.maxLength(20)]),
            employees: new FormControl(),
      });
      this.employeesService
      .getAllEmployeesByDeptId()
      .then(employees => {
        this.employees = employees;
      });

    }
  onSubmit(){
    console.log(this.teamForm.value);
    this.teamsService.createTeam(this.teamForm.value)
    .then((team) => this.router.navigateByUrl('/teams/' + team.id));
  }
  onChange(emp){
    
  }
}
