import { Injectable } from '@angular/core';
import { Http, Headers, RequestOptionsArgs } from '@angular/http';
// import { CookieService } from '';

@Injectable()
export class HttpClient {

    constructor(
        private http: Http,
        // private cookieService: CookieService
    ) { }

    private createAuthorizationHeader(): Headers {
        const headers = new Headers({ 'Content-Type': 'application/json' });
        // if (this.cookieService.get('auth')) {
        //     headers.set('Authorization', 'Bearer ' + this.cookieService.get('auth'))

        //     return headers;
        // }
        return null;
    }

<<<<<<< HEAD
<<<<<<< HEAD
    public Get(url) {
        const headers = this.createAuthorizationHeader();
=======
=======
>>>>>>> 1ca92b8e52444ce39527560b7fbbdd0c3491fccc
    public get(url) {
        let headers = this.createAuthorizationHeader();
>>>>>>> 1ca92b8e52444ce39527560b7fbbdd0c3491fccc
        return this.http.get(url, {
            headers: headers
        });
    }

    public getWithOptions(url, options: RequestOptionsArgs) {
        return this.http.get(url, options);
    }

    public post(url, data) {
        // let headers = this.createAuthorizationHeader();
        // return this.http.post(url, data, {
        //     headers: headers
        // });
    }

    public postWithOptions(url, data, options: RequestOptionsArgs) {
        // let headers = this.createAuthorizationHeader();
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
