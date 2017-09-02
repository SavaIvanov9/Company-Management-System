import { CUSTOM_ELEMENTS_SCHEMA, NO_ERRORS_SCHEMA, NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { BrowserModule } from '@angular/platform-browser';
import { DepartmentsComponent } from './departments/departments.component';
import { DepartmentsService } from './departments/departments.service';
import { HomeComponent } from './home/home.component';
import { LoginFormComponent } from './login/components/login-form.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    LoginFormComponent,
    DepartmentsComponent
  ],
  imports: [
    AppRoutingModule,
    BrowserModule,
  ],
  schemas: [CUSTOM_ELEMENTS_SCHEMA, NO_ERRORS_SCHEMA],
  providers: [DepartmentsService],
  bootstrap: [AppComponent]

})
export class AppModule { }
