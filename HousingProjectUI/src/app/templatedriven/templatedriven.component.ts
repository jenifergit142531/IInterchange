import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-templatedriven',
  templateUrl: './templatedriven.component.html',
  styleUrl: './templatedriven.component.css'
})
export class TemplatedrivenComponent {

  form={
    username:'',
    email:'',
    password:''
  };

OnSubmit():void{
  alert(JSON.stringify(this.form,null,2));
}

onReset(form:NgForm):void{
  form.reset();
}


}
