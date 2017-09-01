import { Component, OnInit } from '@angular/core';

//import { TabMenuModule, MenuItem } from 'primeng/primeng';
import { PanelMenuModule, MenuItem } from 'primeng/primeng';

@Component({
    selector: 'app-home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.css'],
})

export class HomeComponent implements OnInit {

    items: MenuItem[];

    constructor() {
    }

    ngOnInit() {
        console.log('Home page');

        // this.items = [
        //     { label: 'New', icon: 'fa-plus' },
        //     { label: 'Open', icon: 'fa-download' },
        //     { label: 'Undo', icon: 'fa-refresh' }
        // ];

        // this.items = [
        //     { label: 'Stats', icon: 'fa-bar-chart' },
        //     { label: 'Calendar', icon: 'fa-calendar' },
        //     { label: 'Documentation', icon: 'fa-book' },
        //     { label: 'Support', icon: 'fa-support' },
        //     { label: 'Social', icon: 'fa-twitter' }
        // ];
    }
}

