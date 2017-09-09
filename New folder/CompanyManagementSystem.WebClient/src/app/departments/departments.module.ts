import { CommonModule } from '@angular/common';
import { DepartmentDetailsComponent } from './department-details/department-details.component';
import { DepartmentsComponent } from './departments.component';
import { DepartmentsRoutingModule } from './departments-routing.module';
import { DepartmentsService } from './departments.service';
import { NgModule } from '@angular/core';
import { HttpClient } from '../core/services/http-client';

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
