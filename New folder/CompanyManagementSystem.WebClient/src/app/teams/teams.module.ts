import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { TeamsDetailsComponent } from './teams-details.component';
import { TeamsRoutingModule } from './teams-routing.module';
import { TeamsService } from './teams.service';

@NgModule({
  imports: [
    CommonModule,
    TeamsRoutingModule
  ],
  declarations: [TeamsDetailsComponent],
  providers: [TeamsService],

})
export class TeamsModule { }
