import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HttpClient } from '../core/services/http-client';
import { DepartmentsService } from './departments.service';
import { DepartmentsComponent } from './departments.component';
import { DepartmentsRoutingModule } from './departments-routing.module';
import { DepartmentDetailsComponent } from './department-details/department-details.component';

@NgModule({
  imports: [
    CommonModule,
    DepartmentsRoutingModule,
  ],
  declarations: [
    DepartmentsComponent,
    DepartmentDetailsComponent,
  ],
  providers: [DepartmentsService, HttpClient]
})
export class DepartmentsModule { }
