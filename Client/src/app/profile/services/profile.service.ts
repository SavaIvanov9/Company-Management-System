import { Injectable } from '@angular/core';
import { Response, Headers, URLSearchParams } from '@angular/http';
import { Observable } from 'rxjs/Observable';

import { DomainUrl } from '../../shared/constants';
import { User } from '../models/user.model';
import { HttpClient } from '../../core/services/http-client';

@Injectable()
export class ProfileService {
    //private employeeUrl: string = DomainUrl + 'api/Employee';
    private profileUrl: string = DomainUrl + 'api/Auth/';

    constructor(private http: HttpClient) {
    }

    getUser(id: number): Observable<any> {
        return this.http.get(this.profileUrl)
            .map((res: Response) => res.json());
    }
}
