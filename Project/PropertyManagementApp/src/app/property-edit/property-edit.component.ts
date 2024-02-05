import { Component, OnInit } from '@angular/core';
import { PropertyService } from '../property.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-property-edit',
  templateUrl: './property-edit.component.html',
  styleUrl: './property-edit.component.css'
})
export class PropertyEditComponent implements OnInit {

  editedProperty:any={
    id:0,
    name:'',
    type:'',
    price:0
  };


  constructor(private propertyService:PropertyService,private router:Router,private route:ActivatedRoute){}
  ngOnInit(): void {
   const propertyId=Number(this.route.snapshot.paramMap.get('id'));
   this.editedProperty=this.propertyService.getPropertyById(propertyId);
  }

  updateProperty():void{
    this.propertyService.updateProperty(this.editedProperty);
    this.router.navigate(['properties']);
  }

}
