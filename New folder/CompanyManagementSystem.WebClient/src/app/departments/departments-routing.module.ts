import { RouterModule, Routes } from '@angular/router';

import { DepartmentDetailsComponent } from './department-details/department-details.component';
import { DepartmentsComponent } from './departments.component';
import { NgModule } from '@angular/core';

const routes: Routes = [
  { path: '', component: DepartmentsComponent},
  { path: ':id', component: DepartmentDetailsComponent },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class DepartmentsRoutingModule { }
