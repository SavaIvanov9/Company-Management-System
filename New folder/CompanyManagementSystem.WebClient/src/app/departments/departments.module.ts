import { AccordionModule, ButtonsModule } from 'ngx-bootstrap';

import { CommonModule } from '@angular/common';
import { DepartmentDetailsComponent } from './department-details/department-details.component';
import { DepartmentsComponent } from './departments.component';
import { DepartmentsRoutingModule } from './departments-routing.module';
import { DepartmentsService } from './departments.service';
import { NgModule } from '@angular/core';

@NgModule({
  imports: [
    CommonModule,
    DepartmentsRoutingModule,
    AccordionModule.forRoot(),
    ButtonsModule.forRoot(),
  ],
  declarations: [
    DepartmentsComponent,
    DepartmentDetailsComponent,
  ],
  providers : [DepartmentsService]
})
export class DepartmentsModule { }
