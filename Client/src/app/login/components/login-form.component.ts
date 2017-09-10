import { Component, OnInit } from '@angular/core';
import { CookieService } from 'ngx-cookie-service';

import { Credentials } from '../models/credentials.model';
import { Cookie } from '../models/cookie.model';

import { LoginService } from '../services/login.service';

@Component({
    selector: 'app-login-form',
    templateUrl: './login-form.component.html',
    styleUrls: ['./login-form.component.css']
})

export class LoginFormComponent implements OnInit {

    private str: string;
    private credentials: Credentials;
    private isLogging: boolean;
    // private authLoaded: boolean;
    private wrongUserPass: boolean;
    private cookie: Cookie;

    constructor(private loginService: LoginService,
        private cookieService: CookieService) {
        this.credentials = new Credentials();
    }

    ngOnInit() {
        console.log('Login form');
        this.isLogging = false;
        // this.authLoaded = false;
        this.wrongUserPass = false;
    }

    logIn() {
        console.log(this.credentials);
        this.isLogging = true;
        this.loginService.getToken(this.credentials)
            .subscribe((cookie: Cookie) => this.setCookie(cookie.Content),
            error => this.wrongCredentials(error),
            () => {//this.router.navigate(['/about'])
                // if()
                // console.log('Loged in successfuly')
            });
        // .catch(error => this.credentials = undefined)
        // .map((cookie: Cookie) => this.cookie = cookie);
        //     
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

    setCookie(cookieValue: string) {
        this.cookie = new Cookie();
        this.cookie.Content = cookieValue;
        console.log(this.cookie);
        this.cookieService.set('CMS-Cookie', this.cookie.Content);
    }

    wrongCredentials(error) {
        console.log(error)
        this.isLogging = false;
        this.wrongUserPass = true;
        this.credentials = new Credentials();
    }
}

