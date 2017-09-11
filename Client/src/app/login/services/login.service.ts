import { Injectable } from '@angular/core';
import { Response, Headers, URLSearchParams } from '@angular/http';
import { Observable } from 'rxjs/Observable';

import { DomainUrl } from '../../shared/constants';

import { Cookie } from '../models/cookie.model';
import { Credentials } from '../models/credentials.model';
import { User } from '../models/user.model';

import { HttpClient } from '../../core/services/http-client';

@Injectable()
export class LoginService {
    private authUrl: string = DomainUrl + 'api/Auth';

    constructor(private http: HttpClient) {
    }

    getToken(credentials: Credentials): Observable<any> {
        return this.http.post(this.authUrl + '/LogIn', credentials)
            .map((res: Response) => res.json());
    }
}
