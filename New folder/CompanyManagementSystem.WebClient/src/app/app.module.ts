import { HttpModule } from '@angular/http';
import { CookieService } from 'ngx-cookie-service';
import { BrowserModule } from '@angular/platform-browser';
import { LoginService } from './login/services/login.service';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CUSTOM_ELEMENTS_SCHEMA, NO_ERRORS_SCHEMA, NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';

import { HomeComponent } from './home/home.component';
import { LogoutComponent } from './logout/logout.component';
import { ProfileComponent } from './profile/profile.component';
import { AboutUsComponent } from './aboutUs/aboutUs.component';
import { ContactUsComponent } from './contactUs/contactUs.component';
import { DepartmentsModule } from './departments/departments.module';
import { RegisterFormComponent } from './register/register-form.component';
import { LoginFormComponent } from './login/components/login-form.component';

import { StrongItemDirective } from './shared/strongItem.directive';
import { UnderlineItemDirective } from './shared/underlineItem.directive';

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
    UnderlineItemDirective,
    StrongItemDirective
],
  exports: [
    UnderlineItemDirective,
    StrongItemDirective
  ],
  imports: [
    AppRoutingModule,
    BrowserModule,
    DepartmentsModule,
    HttpModule,
    ReactiveFormsModule,
    FormsModule,
  ],
  schemas: [CUSTOM_ELEMENTS_SCHEMA, NO_ERRORS_SCHEMA],
  providers: [CookieService, LoginService],
  bootstrap: [AppComponent]

})
export class AppModule { }
