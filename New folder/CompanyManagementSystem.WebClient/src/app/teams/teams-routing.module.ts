import { RouterModule, Routes } from '@angular/router';

import { NgModule } from '@angular/core';
import { TeamsDetailsComponent } from './teams-details.component';

const routes: Routes = [
  { path: ':id', component: TeamsDetailsComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TeamsRoutingModule { }
