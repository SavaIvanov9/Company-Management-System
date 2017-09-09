import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormArray, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';

import { ActivatedRoute } from '@angular/router';
import { EmployeesService } from './../services/employees.service'
import {Router} from '@angular/router';
import { Team } from './../models/team.model';
import { TeamsService } from './../services/teams.service';

@Component({
  selector: 'app-create-team-form',
  templateUrl: './create-team-form.component.html',
  styleUrls: ['./create-team-form.component.css']
})
export class CreateTeamFormComponent {

  constructor(private teamsService: TeamsService,
    private employeesService: EmployeesService,
    private activatedRoute: ActivatedRoute,
    private router: Router,
    private fb: FormBuilder) { }

    teamForm
    team = {
      employees : []
    }
    allEmployees = [];

    ngOnInit() {
      
      const id = +this.activatedRoute.snapshot.params['id'];
      this.teamForm = new FormGroup({
            departmentId: new FormControl(id),
            name:  new FormControl(null, [Validators.required, Validators.minLength(3), Validators.maxLength(20)]),
            employees: this.fb.array([]),
      });
      this.employeesService
      .getAllEmployeesByDeptId()
      .then(employees => {
        this.allEmployees = employees;
      });

    }
  onSubmit(){
    //console.log(this.teamForm.value);
    // this.teamsService.createTeam(this.teamForm.value)
    // .then((team) => this.router.navigateByUrl('/teams/' + team.id));
  }

  ngOnChanges() {
    this.setEmployees(this.team.employees);
  }

  get employees(): FormArray {
    return this.teamForm.get('employees') as FormArray;
  };

  setEmployees(employees) {
    const employeeFGs = employees.map(emp => this.fb.group(emp));
    const employeeFormArray = this.fb.array(employeeFGs);
    this.teamForm.setControl('employees', employeeFormArray);
  }

  addPerson() {
    this.employees.push(this.fb.group({id : ''}));
  }

}
