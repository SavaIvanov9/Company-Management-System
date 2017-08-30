import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

//import { publicRoutes } from './public/public.routes';
import { loginRoutes } from './login/login-routing.module';

// import { AuthGuard } from './route-guard.service';

export const appRoutes: Routes = [
    // {
    //     path: 'admin',
    //     loadChildren: 'app/admin/admin.module#AdminModule'
    // },
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
        RouterModule.forRoot(appRoutes, { useHash: false })
    ],
    exports: [
        RouterModule
    ],
})
export class AppRoutingModule { }
