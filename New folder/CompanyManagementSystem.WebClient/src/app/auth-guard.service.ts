import 'rxjs/add/operator/do';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/take';

import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot } from '@angular/router';

import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';

@Injectable()
export class AuthGuard implements CanActivate {
  constructor( private router: Router) { }

  canActivate() {
    console.log('AuthGuard#canActivate called');
    return true;
    // return this.afAuth.authState
    // .take(1)
    // .map(user => !!user)
    // .do(loggedIn => {
    //     if (!loggedIn) {
    //         console.log('Access denied!');
    //         this.router.navigateByUrl('/login');
    //     }
    // });
  }
}
  // export class AuthChildrenGuard implements CanActivateChild {
  //   constructor(private router: Router) { }

  //   canActivateChild() {
  //     console.log('AuthChildrenGuard');
  //     return true;
  //   }
  // }


