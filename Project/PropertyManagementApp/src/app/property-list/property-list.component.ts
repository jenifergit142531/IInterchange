import { Component, OnInit } from '@angular/core';
import { PropertyService } from '../property.service';

@Component({
  selector: 'app-property-list',
  templateUrl: './property-list.component.html',
  styleUrl: './property-list.component.css'
})
export class PropertyListComponent implements OnInit {

  properties:any[]=[];
  constructor(private propertyService:PropertyService){}

   ngOnInit(): void {
       this.properties=this.propertyService.getProperties();
   }

}
