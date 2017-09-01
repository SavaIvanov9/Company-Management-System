import { Component, OnInit } from '@angular/core';

import { LoginService } from '../services/login.service';

// import { WinAuth } from '../models/win-auth.model';
// import { Credentials } from '../models/credentials.model';
// import { Cookie } from '../models/cookie.model';

// import {CookieService, CookieOptionsArgs} from 'angular2-cookie/core';
// import { Router } from '@angular/router';
// import { CryptoManager } from '../../core/services/crypto-manager';
// import { CookieKeys } from '../../shared/constants/constants';

@Component({
    selector: 'app-login-form',
    templateUrl: './login-form.component.html',
    styleUrls: ['./login-form.component.css']
})

export class LoginFormComponent implements OnInit {

    // private winAuth: WinAuth;
    // private credentials: Credentials;
    // private cookie: Cookie;
    // private cookieOptionsArgs: CookieOptionsArgs = {};
    private isLogging: boolean;
    private authLoaded: boolean;
    private wrongUserPass: boolean;
    private isDomainAccount: boolean;

    constructor(
        // private loginService: LoginService,
        // private cookieService: CookieService,
        // private router: Router,
        // private cryptoManager: CryptoManager
    ) {
        // this.credentials = new Credentials();
    }

    GetWinAuth() {
        // this.loginService.getWinAuth()
        //     .map((winAuth: WinAuth) => this.winAuth = winAuth)
        //     .subscribe(() => this.authLoaded = true, () => this.authLoaded = true);
    }

    GetToken() {
        // this.isLogging = true;
        // if (this.winAuth) {
        //     this.credentials.UserName = this.winAuth.Name;
        //     this.credentials.Password = this.winAuth.SIDorPass;
        // }
        // this.loginService.GetToken(this.credentials)
        //     .catch(error => this.credentials = undefined)
        //     .map((cookie: Cookie) => this.cookie = cookie)
        //     .map(() => {
        //         this.cookieService.put(CookieKeys.Token, this.cookie.access_token, this.cookieOptionsArgs);
        //         this.cookieService.put(CookieKeys.Username, this.cryptoManager.Encrypt(this.cookie.userName), this.cookieOptionsArgs);
        //         this.cookieService.put(CookieKeys.Position, this.cryptoManager.Encrypt(this.cookie.position), this.cookieOptionsArgs);
        //         this.cookieService.put(CookieKeys.Permissions, this.cryptoManager.Encrypt(this.cookie.permissions), this.cookieOptionsArgs);
        //     })
        //     .subscribe(data => console.log(data),
        //     error => this.WrongCredentials(error),
        //     () => this.router.navigate(['/about']));
    }

    LoginWithOtherAccount() {
        //this.winAuth = undefined;
        this.isDomainAccount = true;
    }

    WrongCredentials(error) {
        console.log(error)
        this.isLogging = false;
        this.wrongUserPass = true;
        //this.credentials = new Credentials();
    }

    Back() {
        this.GetWinAuth();
        this.wrongUserPass = false;
    }

    keyDownFunction(event) {
        if (event.keyCode === 13) {
            this.GetToken()
        }
    }

    ngOnInit() {
        console.log('Login form')
        this.GetWinAuth();
        //this.cookieOptionsArgs.expires = new Date(new Date().getTime() + 180 * 60000);
        this.isLogging = false;
        this.authLoaded = false;
        this.wrongUserPass = false;
        this.isDomainAccount = false;
    }
}

