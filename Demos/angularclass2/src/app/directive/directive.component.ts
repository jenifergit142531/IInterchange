import { Component } from '@angular/core';

@Component({
  selector: 'app-directive',
  templateUrl: './directive.component.html',
  styleUrl: './directive.component.css'
})
export class DirectiveComponent {

  PropShop:any[]=[
    {
    Pid:'Prop001',PropName:'Avisa',Price:25000,Agent:'Aron',
    Availability:'yes',LastUpdatedDate:'2/1/2024'
     },
     {
      Pid:'Prop002',PropName:'Laguna',Price:35000,Agent:'Amy',
      Availability:'no',LastUpdatedDate:'31/1/2024'
       },
       {
        Pid:'Prop003',PropName:'Macarena',Price:15000,Agent:'steve',
        Availability:'yes',LastUpdatedDate:'30/1/2024'
         },
         {
          Pid:'Prop004',PropName:'Ivory',Price:30000,Agent:'Tom',
          Availability:'no',LastUpdatedDate:'15/1/2024'
           },
     
];

price!:number;

CheckPropertyPrice():boolean{
  
  return this.price>5000;
}

public dropdownvalue="";
setDropDownValue(dp:any)
{
  this.dropdownvalue=dp.target.value;
}
}
