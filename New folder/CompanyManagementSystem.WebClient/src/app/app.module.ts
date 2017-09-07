import { AccordionModule, AlertModule, TabsModule } from 'ngx-bootstrap';
import { CUSTOM_ELEMENTS_SCHEMA, NO_ERRORS_SCHEMA, NgModule } from '@angular/core';

import { AboutUsComponent } from './aboutUs/aboutUs.component';
import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { BrowserModule } from '@angular/platform-browser';
import { ContactUsComponent } from './contactUs/contactUs.component';
import { DepartmentsModule } from './departments/departments.module';
import { HomeComponent } from './home/home.component';
import { LoginFormComponent } from './login/components/login-form.component';
import { LogoutComponent } from './logout/logout.component';
import { ProfileComponent } from './profile/profile.component';
import { ResponsiveModule } from 'ng2-responsive';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    AboutUsComponent,
    ContactUsComponent,
    LoginFormComponent,
    ProfileComponent,
    LogoutComponent,

],
  imports: [
    AppRoutingModule,
    BrowserModule,
    DepartmentsModule,
    ResponsiveModule,
    AlertModule.forRoot(),
    TabsModule.forRoot(),
    
  ],
  schemas: [CUSTOM_ELEMENTS_SCHEMA, NO_ERRORS_SCHEMA],
  providers: [],
  bootstrap: [AppComponent]

})
export class AppModule { }
