import { Injectable } from '@angular/core';
import { Response, Headers, URLSearchParams } from '@angular/http';
import { Observable } from 'rxjs/Observable';

import { DomainUrl } from '../../shared/constants';

import { Cookie } from '../models/cookie.model';
import { Credentials } from '../models/credentials.model';
import { User } from '../models/user.model';

import { HttpClient } from '../../core/services/http-client'

@Injectable()
export class LoginService {

    private tokenUrl: string = DomainUrl + 'Token';
    private identityURL: string = DomainUrl + 'api/account/identity';
    private logoutUrl: string = DomainUrl + 'api/account/logout';

    private token: string;
    private username: Observable<string>;

    constructor(private httpClient: HttpClient) {
    }

    GetToken(credentials: Credentials)
        //:Observable<Cookie> 
        {
        let params = new URLSearchParams();
        let headers = new Headers({ 'Content-Type': 'application/x-www-form-urlencoded' });

        params.set('grant_type', 'password');
        params.set('UserName', credentials.UserName);
        params.set('Password', credentials.Password);

        // return this.httpClient.postWithOptions(this.tokenUrl, params, { headers: headers })
        //     .map((res: Response) => {
        //         return res.json();
        //     })
        //     .catch(error => {
        //         if (error.status === 400) {
        //             return Observable.throw('Error!');
        //         }
        //     });
    }
}
