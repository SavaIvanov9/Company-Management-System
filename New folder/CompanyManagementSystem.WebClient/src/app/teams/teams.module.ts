import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { TeamsService } from './services/teams.service';
import { TeamsRoutingModule } from './teams-routing.module';
import { EmployeesService } from '../teams/services/employees.service';
import { TeamsDetailsComponent } from './components/teams-details.component';
import { CreateTeamFormComponent } from './createTeamForm/create-team-form.component';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    TeamsRoutingModule
  ],
  declarations: [
    TeamsDetailsComponent,
    CreateTeamFormComponent
  ],
  providers: [TeamsService, EmployeesService],

})

export class TeamsModule { }
