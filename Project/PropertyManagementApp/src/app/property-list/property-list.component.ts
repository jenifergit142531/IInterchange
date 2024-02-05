import { Component, OnInit } from '@angular/core';
import { PropertyService } from '../property.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-property-list',
  templateUrl: './property-list.component.html',
  styleUrl: './property-list.component.css'
})
export class PropertyListComponent implements OnInit {

  properties:any[]=[];
  constructor(private propertyService:PropertyService,private router:Router){}

   ngOnInit(): void {
       this.properties=this.propertyService.getProperties();
   }

   editProperty(id:number):void{
     this.router.navigate([`properties/edit/${id}`]);
   }

}
