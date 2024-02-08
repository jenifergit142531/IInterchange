import { Component } from '@angular/core';
import { HouseserviceService } from '../houseservice.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {

  username:string='';
  password:string='';

  constructor(private authService:HouseserviceService,private router:Router){}

  onSubmit():void{
    this.authService.login(this.username,this.password)
    .subscribe({

  
      next:(user)=>
      {
        alert("Login successful");
        this.router.navigate(['hlist']);
      },
      error:(response)=>
      {
        alert('Username or Password is invalid');
        console.log(response);
      }

    }
      
    )
  }

}
