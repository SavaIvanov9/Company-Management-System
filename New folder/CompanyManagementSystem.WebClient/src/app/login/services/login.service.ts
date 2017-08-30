import { Injectable } from '@angular/core';

import { Response, Headers, URLSearchParams } from '@angular/http';

import { Observable } from 'rxjs/Observable';
import { of } from 'rxjs/observable/of';

// import { TokenUrl, DomainAuthUrl } from '../../shared/constants/constants';
// import { ErrorHandler } from '../../shared/handlers/error-handler';

// import { WinAuth } from '../models/win-auth.model';
// import { Cookie } from '../models/cookie.model';
// import { Credentials } from '../models/credentials.model';
// import { User } from '../models/user.model';

import 'rxjs/add/observable/empty';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/switchMap';
import 'rxjs/add/operator/catch';

// import { CookieService, CookieOptionsArgs } from 'angular2-cookie/core';
// import { HttpClient } from '../../core/services/http-client'

@Injectable()
export class LoginService {

    // private tokenUrl: string = TokenUrl + 'Token';
    // private identityURL: string = TokenUrl + 'api/account/identity';
    // private logoutUrl: string = TokenUrl + 'api/account/logout';
    // private domainAuthUrl: string = DomainAuthUrl + 'api/auth';

    // private winAuth: Observable<WinAuth>;
    // private token: string;
    // private username: Observable<string>;

    // constructor(private httpClient: HttpClient, private errorHandler: ErrorHandler, private cookieService: CookieService) {
    // }

    // getWinAuth(): Observable<WinAuth> {
    //     this.winAuth = this.httpClient.getWithOptions(this.domainAuthUrl, { withCredentials: true })
    //         .map((res: Response) => res.json());

    //     return this.winAuth;
    // }

    // GetToken(credentials: Credentials): Observable<Cookie> {
    //     let params = new URLSearchParams();
    //     let headers = new Headers({ 'Content-Type': 'application/x-www-form-urlencoded' });

    //     params.set('grant_type', 'password');
    //     params.set('UserName', credentials.UserName);
    //     params.set('Password', credentials.Password);

    //     return this.httpClient.postWithOptions(this.tokenUrl, params, { headers: headers })
    //         .map((res: Response) => {
    //             return res.json();
    //         })
    //         .catch(error => {
    //             if (error.status === 400) {
    //                 return Observable.throw('GRESHKA!');
    //             }
    //         });
    // }

    LogOut() {
        //return this.httpClient.post(this.logoutUrl, null);
    }
}
