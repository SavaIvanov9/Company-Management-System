import { RouterModule, Routes } from '@angular/router';

import { CreateTeamFormComponent } from './createTeamForm/create-team-form.component';
import { NgModule } from '@angular/core';
import { TeamsDetailsComponent } from './teams-details.component';

const routes: Routes = [
  { path: 'form/:id', component: CreateTeamFormComponent },
  { path: ':id', component: TeamsDetailsComponent }
];

@NgModule({
  imports: [
    RouterModule.forChild(routes),
  ],
  exports: [RouterModule]
})
export class TeamsRoutingModule { }
