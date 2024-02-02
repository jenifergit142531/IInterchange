import { Component } from '@angular/core';

@Component({
  selector: 'app-pipe',
  templateUrl: './pipe.component.html',
  styleUrl: './pipe.component.css'
})
export class PipeComponent {

  employees:any[]=[
    {empid:'e100',empname:'Amy',role:'TRAINER',gender:'Female',doj:'10/4/2024',salary:56789},
    {empid:'e200',empname:'Aron',role:'Manager',gender:'Male',doj:'11/4/2024',salary:67890},
    {empid:'e300',empname:'Steve',role:'SE',gender:'Male',doj:'14/4/2024',salary:78901},
    {empid:'e400',empname:'Jon',role:'BA',gender:'Male',doj:'5/4/2024',salary:89012}
  ]
}
