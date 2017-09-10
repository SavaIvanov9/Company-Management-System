import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { CommonModule } from '@angular/common';
import { CreateTeamFormComponent } from './createTeamForm/create-team-form.component';
import { EmployeesService } from '../teams/services/employees.service';
import { NgModule } from '@angular/core';
import { TeamsDetailsComponent } from './components/teams-details.component';
import { TeamsRoutingModule } from './teams-routing.module';
import { TeamsService } from './services/teams.service';

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
  providers: [EmployeesService],

})

export class TeamsModule { }
