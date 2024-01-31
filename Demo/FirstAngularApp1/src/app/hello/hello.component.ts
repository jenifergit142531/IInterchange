import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-hello',
  templateUrl: './hello.component.html',
  //template:'<p>hello works!</p>',
  styleUrl: './hello.component.css'
 // styles:'p { background-color: red;}'
})
export class HelloComponent{

  //properties
  public message:string='Hello Angular!!!';
  public count:number=0;
  public userInput:string='';

  //methods
 
  showMessage():void{
    alert(this.message);
  }

  incrementCounter():void{
    this.count++;
  }

}
