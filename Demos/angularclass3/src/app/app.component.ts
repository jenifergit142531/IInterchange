import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'angularclass3';

  constructor(private router:Router){}

  getHome()
  {
    this.router.navigate(['home']);
  }

  getContact()
  {
    this.router.navigate(['contact']);
  }
  
  
}
