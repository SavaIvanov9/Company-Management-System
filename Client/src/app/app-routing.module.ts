import { PreloadAllModules, RouterModule, Routes } from '@angular/router';

import { AboutUsComponent } from './aboutUs/aboutUs.component';
import { AuthGuard } from './core/services/auth-guard.service';
import { ContactUsComponent } from './contactUs/contactUs.component';
import { DepartmentsComponent } from './departments/departments.component';
import { HomeComponent } from './home/home.component';
import { LoginFormComponent } from './login/components/login-form.component';
import { LogoutComponent } from './logout/logout.component';
import { NgModule } from '@angular/core';
import { ProfileComponent } from './profile/profile.component';
import { RegisterFormComponent } from './register/register-form.component';

const routes: Routes = [
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  { path: 'home', component: HomeComponent },
  { path: 'aboutus', component: AboutUsComponent },
  { path: 'contactus', component: ContactUsComponent },
  { path: 'login', component: LoginFormComponent },
  { path: 'register', component: RegisterFormComponent },
  { path: 'profile', component: ProfileComponent, canActivate: [AuthGuard] },
  { path: 'logout', component: LogoutComponent },
  {path: 'departments', loadChildren: './departments/departments.module#DepartmentsModule', canActivate: [AuthGuard]},
  {path: 'teams', loadChildren: './teams/teams.module#TeamsModule', canActivate: [AuthGuard] }
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, { useHash: false })
  ],
  exports: [
    RouterModule
  ],
})

// @NgModule({
//     imports: [RouterModule.forRoot(routes, { preloadingStrategy: PreloadAllModules })],
//     exports: [RouterModule]
// })

export class AppRoutingModule { }
