import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { LoginComponent } from './login.component';
import { LoginFormComponent } from './components/login-form.component';

export const loginRoutes: Routes = [
  {
    path: 'auth',
    component: LoginComponent,
    children: [
      {
        path: 'login',
        component: LoginFormComponent
      },
      {
        path: 'auth',
        pathMatch: 'full',
        redirectTo: '/login'
      }
    ]
  }
];

export const loginRouting = RouterModule.forChild(loginRoutes);