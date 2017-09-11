import { User } from './models/user.model';
import { Component, OnInit } from '@angular/core';
import { ProfileService } from './services/profile.service';
import { AuthService } from '../core/services/auth.service';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {

  constructor(private profileService: ProfileService,
    private AuthService: AuthService) { }

  user: User = new User();

  ngOnInit() {
    console.log(this.AuthService.loggedInUserId)
    this.profileService.getUser(this.AuthService.loggedInUserId)
      .subscribe((result) => { 
        console.log(result)
        this.user = result;
        console.log(this.user)
      });
  }
}
