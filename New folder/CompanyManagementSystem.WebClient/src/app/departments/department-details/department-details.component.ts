import { ActivatedRoute, ParamMap } from '@angular/router';
import { Component, OnInit } from '@angular/core';

import { DepartmentsService } from './../departments.service';

@Component({
  selector: 'app-department-details',
  templateUrl: './department-details.component.html',
  styleUrls: ['./department-details.component.css']
})
export class DepartmentDetailsComponent implements OnInit {
  dep = {}
  teams = []

  constructor(private departmentsSevice: DepartmentsService,
    private activatedRoute: ActivatedRoute) { }

  ngOnInit() {

    const id = +this.activatedRoute.snapshot.params['id'];

    this.departmentsSevice
      .getDepartmentById(id)
      .then(dep => {
        this.dep = dep
        this.teams = dep.teams
      }
      );
  }

}
