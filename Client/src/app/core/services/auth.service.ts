import { Injectable } from '@angular/core';

@Injectable()
export class AuthService {
    private coockieName: string;
    private cookieValue: string;

    public loggedInUserId: number;
    constructor() {
        this.coockieName = 'CMSCookie';
    }

    checkIsAuthenticated(): boolean {
        // console.log("home cookie");
        // console.log(this.cookie);
        if (this.getCookie()) {
            return true;
        } else {
            return false;
        }
    }

    get isAuthenticated(): boolean {
        return this.checkIsAuthenticated();
    }

    getCookie() {
        return localStorage.getItem(this.coockieName);
    }

    setCookie(value: string) {
        this.cookieValue = value;
        localStorage.setItem(this.coockieName, value);
    }

    signOut(): void {
        this.cookieValue = undefined;
        localStorage.removeItem(this.coockieName);
    }
}