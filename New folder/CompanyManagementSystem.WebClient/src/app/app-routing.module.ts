import { NgModule } from '@angular/core';
import { Routes, RouterModule, PreloadAllModules } from '@angular/router';

//import { publicRoutes } from './public/public.routes';
import { loginRoutes } from './login/login-routing.module';
//import { LoginComponent } from './login/login.component';
import { LoginFormComponent } from './login/components/login-form.component';

// import { AuthGuard } from './route-guard.service';


// const routes: Routes = [
//     //   { path: '', redirectTo: 'home', pathMatch: 'full' },
//     // { path: '', redirectTo: 'login', pathMatch: 'full' },
//     { path: 'login', component: LoginFormComponent },
//     //   { path: 'users', loadChildren: './users/users.module#UsersModule' }
// ];

const routes: Routes = [
    {
        path: 'auth',
        children: [...loginRoutes]
    },
    // {
    //     path: '',
    //     children: [...publicRoutes],
    //     canActivate: [AuthGuard]
    // }
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
