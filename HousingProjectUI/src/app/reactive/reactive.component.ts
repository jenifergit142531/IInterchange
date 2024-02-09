import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';


@Component({
  selector: 'app-reactive',
  templateUrl: './reactive.component.html',
  styleUrl: './reactive.component.css'
})
export class ReactiveComponent implements OnInit{


  
 
  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }

  userform=new FormGroup({
    'username':new FormControl('',[Validators.required,Validators.minLength(6),Validators.maxLength(20)]),
    'email':new FormControl('',[Validators.email,Validators.required]),
    'password':new FormControl('',[Validators.required,Validators.minLength(6),Validators.maxLength(20)])

  });

  /*userform=this.fb.group({
    username:['username',Validators.required,Validators.minLength(6),Validators.maxLength(20)],
    email:['email',Validators.email,Validators.required],
    password:['password',Validators.required,Validators.minLength(6),Validators.maxLength(20)]
  });*/

  save()
  {
    alert(JSON.stringify(this.userform.value));
  }



  

}
