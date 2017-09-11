import { CUSTOM_ELEMENTS_SCHEMA, NO_ERRORS_SCHEMA, NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AboutUsComponent } from './aboutUs/aboutUs.component';
import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { AuthGuard } from './core/services/auth-guard.service';
import { BrowserModule } from '@angular/platform-browser';
import { ContactUsComponent } from './contactUs/contactUs.component';
import { CookieService } from 'ngx-cookie-service';
import { DepartmentsModule } from './departments/departments.module';
import { HomeComponent } from './home/home.component';
import { HttpModule } from '@angular/http';
import { LoginFormComponent } from './login/components/login-form.component';
import { LoginService } from './login/services/login.service';
import { LogoutComponent } from './logout/logout.component';
import { ProfileComponent } from './profile/profile.component';
import { RegisterFormComponent } from './register/register-form.component';
import { StrongItemDirective } from './shared/strongItem.directive';
import { TeamsService } from './teams/services/teams.service';
import { UnderlineItemDirective } from './shared/underlineItem.directive';
import { RegisterService } from './register/services/register.service';
import { AuthService } from './core/services/auth.service';

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
  providers: [
    AuthGuard,
    TeamsService,
    CookieService,
    LoginService,
    RegisterService,
    AuthService
  ],
  bootstrap: [AppComponent]

})
export class AppModule { }
