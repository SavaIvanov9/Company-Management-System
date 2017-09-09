import { CUSTOM_ELEMENTS_SCHEMA, NO_ERRORS_SCHEMA, NgModule } from '@angular/core';

import { AboutUsComponent } from './aboutUs/aboutUs.component';
import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { BrowserModule } from '@angular/platform-browser';
import { ContactUsComponent } from './contactUs/contactUs.component';
import { DepartmentsModule } from './departments/departments.module';
import { EmployeesService } from './teams/employees.service';
import { HomeComponent } from './home/home.component';
import { LoginFormComponent } from './login/components/login-form.component';
import { LogoutComponent } from './logout/logout.component';
import { ProfileComponent } from './profile/profile.component';
import { RegisterFormComponent } from './register/register-form.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    AboutUsComponent,
    ContactUsComponent,
    LoginFormComponent,
    ProfileComponent,
    LogoutComponent,
    RegisterFormComponent,
],
  imports: [
    AppRoutingModule,
    BrowserModule,
    DepartmentsModule
  ],
  schemas: [CUSTOM_ELEMENTS_SCHEMA, NO_ERRORS_SCHEMA],
  providers: [EmployeesService],
  bootstrap: [AppComponent]

})
export class AppModule { }
