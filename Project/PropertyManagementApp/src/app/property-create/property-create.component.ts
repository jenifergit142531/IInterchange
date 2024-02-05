import { Component } from '@angular/core';
import { PropertyService } from '../property.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-property-create',
  templateUrl: './property-create.component.html',
  styleUrl: './property-create.component.css'
})
export class PropertyCreateComponent {

  pname:string='';
  ptype:string='';
  pprice:number=0;

  constructor(private propertyService:PropertyService,private router:Router){};

  addProperty():void{
    if(this.pname&&this.ptype&&this.pprice>=0){
      this.propertyService.addProperty({
        name:this.pname,
        type:this.ptype,
        price:this.pprice
      });

      this.router.navigate([`properties`]);

    /* this.pname='';
     this.ptype='';
     this.pprice=0;*/
    }
  }
}
