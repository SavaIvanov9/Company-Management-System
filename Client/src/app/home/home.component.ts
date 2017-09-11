import { Component, OnInit } from '@angular/core';

// import { TabMenuModule, MenuItem } from 'primeng/primeng';
import { PanelMenuModule, MenuItem } from 'primeng/primeng';

@Component({
    selector: 'app-home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.css'],
})

export class HomeComponent implements OnInit {
    private toggled: boolean;
    items: MenuItem[];

    constructor() {
    }

    ngOnInit() {
    }

    HideNav() {
        if (this.CalcDisplayWidth() < 768) {
            this.toggled = false;
        } else {
        }
    }

    ToggleNavbar() {
        this.toggled = !this.toggled;
    }

    CalcDisplayWidth() {
        return Math.max(document.documentElement.clientWidth, window.innerWidth || 0);
    }
}

