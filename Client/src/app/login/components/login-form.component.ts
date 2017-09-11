import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CookieService } from 'ngx-cookie-service';

import { Credentials } from '../models/credentials.model';
import { Cookie } from '../models/cookie.model';

import { LoginService } from '../services/login.service';
import { AuthService } from '../../core/services/auth.service';

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
        private cookieService: CookieService,
        private router: Router,
        private authService: AuthService) {
        this.credentials = new Credentials();
    }

    ngOnInit() {
        this.isLogging = false;
        // this.authLoaded = false;
        this.wrongUserPass = false;
    }

    logIn() {
        this.isLogging = true;
        this.loginService.getToken(this.credentials)
            .subscribe((cookie) => {
                this.setCookie(cookie.content);
                this.authService.loggedInUserId = cookie.UserId;
                this.router.navigate(['/home'])
            },
            error => this.wrongCredentials(error),
            () => { });
    }

    setCookie(cookieValue: string) {
        this.cookie = new Cookie();
        this.cookie.Content = cookieValue;
        this.authService.setCookie(cookieValue);
    }

    wrongCredentials(error) {
        this.isLogging = false;
        this.wrongUserPass = true;
        this.credentials = new Credentials();
    }
}

