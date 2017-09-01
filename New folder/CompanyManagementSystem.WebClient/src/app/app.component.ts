import { Component } from '@angular/core';

import { TabMenuModule, MenuItem } from 'primeng/primeng';

//import { RouterOutlet } from '@angular/router';

// @Component({
//   selector: 'app-root',
//   templateUrl: './app.component.html',
//   styleUrls: ['./app.component.css']
// })
// export class AppComponent {
//   title = 'app';
// }

@Component({
    selector: 'app-root',
    template: `<router-outlet></router-outlet>`
})
export class AppComponent {
    title = 'CompanySystem';
}
