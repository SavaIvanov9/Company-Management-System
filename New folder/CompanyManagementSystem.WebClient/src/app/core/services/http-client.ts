import { Injectable } from '@angular/core';
import { Http, Headers, RequestOptionsArgs } from '@angular/http';
import { CookieService } from 'ngx-cookie-service';

@Injectable()
export class HttpClient {

    constructor(private http: Http,
        private cookieService: CookieService)
    { }

    private createAuthorizationHeader(): Headers {
        const headers = new Headers({ 'Content-Type': 'application/json'});
        let cookie = this.cookieService.get('auth');
        console.log(`cookie`)
        console.log(cookie)
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
        let headers = this.createAuthorizationHeader();
        return this.http.post(url, data, {
            headers: headers
        });
    }

    public postWithOptions(url, data, options: RequestOptionsArgs) {
        let headers = this.createAuthorizationHeader();
        return this.http.post(url, data, options);
    }

    public put(url, data) {
        // let headers = this.createAuthorizationHeader();
        // return this.http.put(url, data, {
        //     headers: headers
        // });
    }

    public delete(url) {
        // let headers = this.createAuthorizationHeader();
        // return this.http.delete(url, {
        //     headers: headers
        // });
    }
}
