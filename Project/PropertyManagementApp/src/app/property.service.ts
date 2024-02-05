import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class PropertyService {

  //mock data

  private properties:any[]=[
    {id:1,name:'avisa',type:'holidayhome',price:35000},
    {id:2,name:'Demeter',type:'coliving',price:8000},
    {id:3,name:'ivory',type:'holidayhome',price:24000}
  ]

  getProperties():any[]{
    return this.properties;
  }

  getPropertyById(id:number):any{
    return this.properties.find(property=>property.id===id);
  }

  addProperty(property:any):void{
    this.properties.push({...property,id:this.properties.length+1});
  }

  updateProperty(updatedProperty:any):void{
    const index=this.properties.findIndex(property=>property.id===updatedProperty.id);
    if(index!=-1)
    {
      this.properties[index]=updatedProperty;
    }
  }

  deleteProperty(id:number):void{
    this.properties=this.properties.filter(property=>property.id!==id);
  }
}
