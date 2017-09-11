import { HttpModule } from '@angular/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CUSTOM_ELEMENTS_SCHEMA, NO_ERRORS_SCHEMA, NgModule } from '@angular/core';

// Modules
import { AppRoutingModule } from './app-routing.module';
import { BrowserModule } from '@angular/platform-browser';
import { DepartmentsModule } from './departments/departments.module';

// Components
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { LogoutComponent } from './logout/logout.component';
import { AboutUsComponent } from './aboutUs/aboutUs.component';
import { ProfileComponent } from './profile/profile.component';
import { ContactUsComponent } from './contactUs/contactUs.component';
import { RegisterFormComponent } from './register/register-form.component';
import { LoginFormComponent } from './login/components/login-form.component';

// Pipes and Directives
import { StrongItemDirective } from './shared/strongItem.directive';
import { UnderlineItemDirective } from './shared/underlineItem.directive';
import { UpperCaseFirstLetterPipe } from './shared/upperCase-firstLetter.pipe';

// Services
import { CookieService } from 'ngx-cookie-service';
import { AuthService } from './core/services/auth.service';
import { LoginService } from './login/services/login.service';
import { TeamsService } from './teams/services/teams.service';
import { AuthGuard } from './core/services/auth-guard.service';
import { ProfileService } from './profile/services/profile.service';
import { RegisterService } from './register/services/register.service';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    LogoutComponent,
    AboutUsComponent,
    ProfileComponent,
    ContactUsComponent,
    LoginFormComponent,
    StrongItemDirective,
    RegisterFormComponent,
    UnderlineItemDirective,
    UpperCaseFirstLetterPipe
],
  exports: [
    StrongItemDirective,
    UnderlineItemDirective,
    UpperCaseFirstLetterPipe
  ],
  imports: [
    HttpModule,
    FormsModule,
    BrowserModule,
    AppRoutingModule,
    DepartmentsModule,
    ReactiveFormsModule,
  ],
  schemas: [CUSTOM_ELEMENTS_SCHEMA, NO_ERRORS_SCHEMA],
  providers: [
    AuthGuard,
    AuthService,
    LoginService,
    TeamsService,
    CookieService,
    ProfileService,
    RegisterService
  ],
  bootstrap: [AppComponent]

})
export class AppModule { }
