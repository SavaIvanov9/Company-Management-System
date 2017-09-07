import { CommonModule } from '@angular/common';
import { CreateTeamFormComponent } from './createTeamForm/create-team-form.component';
import { NgModule } from '@angular/core';
import { TeamsDetailsComponent } from './teams-details.component';
import { TeamsRoutingModule } from './teams-routing.module';
import { TeamsService } from './teams.service';

@NgModule({
  imports: [
    CommonModule,
    TeamsRoutingModule
  ],
  declarations: [TeamsDetailsComponent, CreateTeamFormComponent],
  providers: [TeamsService],

})
export class TeamsModule { }
