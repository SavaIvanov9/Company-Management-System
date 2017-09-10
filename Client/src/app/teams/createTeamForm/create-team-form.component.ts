import { Component, EventEmitter, OnChanges, OnInit, Output } from '@angular/core';
import { FormArray, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';

import { ActivatedRoute } from '@angular/router';
import { EmployeesService } from './../services/employees.service';
import { Router } from '@angular/router';
import { Team } from './../models/team.model';
import { TeamCreateModel } from './../models/teamCreate.model';
import { TeamsService } from './../services/teams.service';
import { User } from '../../profile/models/user.model';

@Component({
  selector: 'app-create-team-form',
  templateUrl: './create-team-form.component.html',
  styleUrls: ['./create-team-form.component.css']
})
export class CreateTeamFormComponent implements OnInit, OnChanges {

  constructor(private teamsService: TeamsService,
    private employeeService: EmployeesService,
    private activatedRoute: ActivatedRoute,
    private router: Router,
    private fb: FormBuilder) { }

  teamForm;

  team = {
    employees: []
  };

  allEmployees = [];

  get employees(): FormArray {
    return this.teamForm.get('employees') as FormArray;
  }

  // tslint:disable-next-line:use-life-cycle-interface
  ngOnInit() {
    const id = this.getDepartmentId();
    this.teamForm = new FormGroup({
      departmentId: new FormControl(id),
      name: new FormControl(null, [Validators.required, Validators.minLength(3), Validators.maxLength(20)]),
      employees: this.fb.array([]),
    });

    this.loadEmployees(id);
  }

  private loadEmployees(id: number) {
    this.employeeService
      .getAllEmployeesByDeptId(id)
      .subscribe((result: User[]) => {
        this.allEmployees = result;
      });
  }

  private onSubmit() {
    console.log('submit');
    console.log(this.teamForm.value);
    const data = new TeamCreateModel();
    data.TeamName = this.teamForm.value.name;
    data.DepartmentId = this.teamForm.value.departmentId;
    data.EmployeeIds = this.teamForm.value.employees.map(e => e.id);
    console.log(data);
    this.teamsService.createTeam(data).subscribe((team) => {
      this.router.navigateByUrl('/teams/' + team.Id);
    });
  }

  public ngOnChanges() {
    this.setEmployees(this.team.employees);
  }

  private setEmployees(employees) {
    const employeeFGs = employees.map(emp => this.fb.group(emp));
    // const employeeFGs = employees.map(emp => emp.id);
    const employeeFormArray = this.fb.array(employeeFGs);
    this.teamForm.setControl('employees', employeeFormArray);
  }

  private addPerson() {
    this.employees.push(this.fb.group({ id: '' }));
  }

  private getDepartmentId(): number {
    return this.activatedRoute.snapshot.params['id'];
  }
}
