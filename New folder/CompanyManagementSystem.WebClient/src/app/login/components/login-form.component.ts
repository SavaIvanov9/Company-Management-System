import { Component, OnInit } from '@angular/core';

import { LoginService } from '../services/login.service';

@Component({
    selector: 'app-login-form',
    templateUrl: './login-form.component.html',
    styleUrls: ['./login-form.component.css']
})

export class LoginFormComponent implements OnInit {

    constructor() {
    }

    ngOnInit() {
        console.log('Login form')
    }
}

