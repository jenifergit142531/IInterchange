import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {

  IsBold:boolean=true;
  fontsize:number=40;
  ApplyBoldClass:boolean=true;
  ApplyItaticClass:boolean=true;

  boldclass:string='boldclass';
  tableheader:string="Student Details";
  textColour:string ='text-primary';
  columnspan:number=2;
  rowspan:number=2;
   name:string='Aron';
   age:number=25;
   grade:string='A';
   mobile:number=2345678;
   gender:string='male'
   //image : string="data:image/jpeg;base64,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";

   showDetails:boolean=true;
toggle():void
{
  this.showDetails=!this.showDetails;
}

AddCssClassess()
{
 let classes={
  boldclass:this.ApplyBoldClass,
  italicclass:this.ApplyItaticClass

 };
 return classes;
}

AddMultipleStyles()
{
  let Styles={
    'background-color':'yellow',
    'font-style':'italic',
    'font-size.px':156,
    'font-name':'times new roman',
    'color':'blue'
  

  };
  return Styles;
}

onClick():void{
  console.log("Button is clicked");
}
}