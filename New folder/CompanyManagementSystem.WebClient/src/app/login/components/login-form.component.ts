import { Component, OnInit } from '@angular/core';

import { Credentials } from '../models/credentials.model';
import { Cookie } from '../models/cookie.model';

import { LoginService } from '../services/login.service';

@Component({
    selector: 'app-login-form',
    templateUrl: './login-form.component.html',
    styleUrls: ['./login-form.component.css']
})

export class LoginFormComponent implements OnInit {

    private credentials: Credentials;
    private isLogging: boolean;
    // private authLoaded: boolean;
    private wrongUserPass: boolean;

    constructor(private loginService: LoginService) {
        this.credentials = new Credentials();
    }

    ngOnInit() {
        console.log('Login form');
        this.isLogging = false;
        // this.authLoaded = false;
        this.wrongUserPass = false;
    }

    GetToken() {
        this.isLogging = true;
        this.loginService.GetToken(this.credentials)
        //     .catch(error => this.credentials = undefined)
        //     .map((cookie: Cookie) => this.cookie = cookie)
        //     .map(() =>
        //     {             
        //         this.cookieService.put(CookieKeys.Token, this.cookie.access_token, this.cookieOptionsArgs);
        //         this.cookieService.put(CookieKeys.Username, this.cryptoManager.Encrypt(this.cookie.userName), this.cookieOptionsArgs);
        //         this.cookieService.put(CookieKeys.Position, this.cryptoManager.Encrypt(this.cookie.position), this.cookieOptionsArgs);
        //         this.cookieService.put(CookieKeys.Permissions, this.cryptoManager.Encrypt(this.cookie.permissions), this.cookieOptionsArgs);
        //     })
        //  .subscribe(data => console.log(data),
        //  error => this.WrongCredentials(error),
        //  () => this.router.navigate(['/about']));
    }

    WrongCredentials(error) {
        console.log(error)
        this.isLogging = false;
        this.wrongUserPass = true;
        this.credentials = new Credentials();
    }
}

