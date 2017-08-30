import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { LoginService } from './services/login.service';

import { LoginComponent } from './login.component';
import { LoginFormComponent } from './components/login-form.component';

import { loginRouting } from './login-routing.module';
@NgModule({
    imports: [
        CommonModule,
        FormsModule,
        loginRouting
    ],
    declarations: [
        LoginComponent,
        LoginFormComponent
    ],
    providers: [
        //LoginService,
        //HttpClient
    ]
})
export class LoginModule { }