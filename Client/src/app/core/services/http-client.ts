import { Injectable } from '@angular/core';
import { Http, Headers, RequestOptionsArgs } from '@angular/http';
import { CookieService } from 'ngx-cookie-service';
import { AuthService } from './auth.service';

@Injectable()
export class HttpClient {

    constructor(private http: Http,
        private cookieService: CookieService,
        private auth: AuthService) {
    }

    private createAuthorizationHeader(): Headers {
        const headers = new Headers({ 'Content-Type': 'application/json' });
        const cookie = this.auth.getCookie();

        if (cookie) {
            headers.set('Authorization', cookie);
            return headers;
        }

        return null;
    }

    public get(url) {
        const headers = this.createAuthorizationHeader();
        return this.http.get(url, {
            headers: headers
        });
    }

    public getWithOptions(url, options: RequestOptionsArgs) {
        return this.http.get(url, options);
    }

    public post(url, data) {
        const headers = this.createAuthorizationHeader();
        return this.http.post(url, data, {
            headers: headers
        });
    }

    public postWithOptions(url, data, options: RequestOptionsArgs) {
        const headers = this.createAuthorizationHeader();
        return this.http.post(url, data, options);
    }

    public put(url, data) {
    }

    public delete(url) {
    }
}
