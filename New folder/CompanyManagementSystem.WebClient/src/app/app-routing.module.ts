import { PreloadAllModules, RouterModule, Routes } from '@angular/router';

import { DepartmentsComponent } from './departments/departments.component';
import { HomeComponent } from './home/home.component';
import { LoginFormComponent } from './login/components/login-form.component';
import { NgModule } from '@angular/core';

//import { LoginComponent } from './login/login.component';
//import { LoginFormComponent } from './login/components/login-form.component';

// import { AuthGuard } from './route-guard.service';


// const routes: Routes = [
//     //   { path: '', redirectTo: 'home', pathMatch: 'full' },
//     // { path: '', redirectTo: 'login', pathMatch: 'full' },
//     { path: 'login', component: LoginFormComponent },
//     //   { path: 'users', loadChildren: './users/users.module#UsersModule' }
// ];

const routes: Routes = [
  { path: '', redirectTo: 'departments', pathMatch: 'full' },
  { path: 'home', component: DepartmentsComponent },
  { path: 'login', component: LoginFormComponent },
  { path: 'departments', loadChildren: './departments/departments.module#DepartmentsModule' },
  { path: 'teams', loadChildren: './teams/teams.module#TeamsModule' }
];

// const routes: Routes = [
//     {
//         path: 'auth',
//         //children: [...loginRouting]
//         children: loginRouting
//     },
//     // {
//     //     path: '',
//     //     children: [...publicRoutes],
//     //     canActivate: [AuthGuard]
//     // }
// ];

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
