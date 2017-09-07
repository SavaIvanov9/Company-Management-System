import { CUSTOM_ELEMENTS_SCHEMA, NO_ERRORS_SCHEMA, NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { BrowserModule } from '@angular/platform-browser';
import { DepartmentsModule } from './departments/departments.module';
import { HomeComponent } from './home/home.component';
import { LoginFormComponent } from './login/components/login-form.component';
import { AboutUsComponent } from './aboutUs/aboutUs.component';
import { ContactUsComponent } from './contactUs/contactUs.component';
import { ProfileComponent } from './profile/profile.component';
import { LogoutComponent } from './logout/logout.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    AboutUsComponent,
    ContactUsComponent,
    LoginFormComponent,
    ProfileComponent,
    LogoutComponent
],
  imports: [
    AppRoutingModule,
    BrowserModule,
    DepartmentsModule,
  ],
  schemas: [CUSTOM_ELEMENTS_SCHEMA, NO_ERRORS_SCHEMA],
  providers: [],
  bootstrap: [AppComponent]

})
export class AppModule { }
