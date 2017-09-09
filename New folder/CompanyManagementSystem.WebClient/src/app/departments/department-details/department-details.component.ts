import { ActivatedRoute, ParamMap } from '@angular/router';
import { Component, OnInit } from '@angular/core';

import { DepartmentsService } from './../departments.service';

import { Department } from '../models/department.model';
import { Team } from '../../teams/models/team.model';
 
@Component({
  selector: 'app-department-details',
  templateUrl: './department-details.component.html',
  styleUrls: ['./department-details.component.css']
})
export class DepartmentDetailsComponent implements OnInit {
  private dep: Department = new Department();
  teams = []

  constructor(private departmentsSevice: DepartmentsService,
    private activatedRoute: ActivatedRoute) { }

  ngOnInit() {

    //const id = + this.activatedRoute.snapshot.params['id'];

    // this.departmentsSevice
    //   .getDepartmentById(id)
    //   .then(dep => {
    //     this.dep = dep
    //     this.teams = dep.teams
    //   }
    //   );

    this.GetDepartmentDetails(this.GetDepartmentId());
  }

  private GetDepartmentDetails(id) {
    this.departmentsSevice.getDepartmentById(id)
      .subscribe((department: Department) => {
        this.dep = department;
      });
  }

  private GetDepartmentId(): number {
    return this.activatedRoute.snapshot.params['id'];
  }
}
