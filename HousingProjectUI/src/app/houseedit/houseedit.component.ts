import { Component, OnInit } from '@angular/core';
import { HouseserviceService } from '../houseservice.service';
import { ActivatedRoute, Router } from '@angular/router';
import { House } from '../house';

@Component({
  selector: 'app-houseedit',
  templateUrl: './houseedit.component.html',
  styleUrl: './houseedit.component.css'
})
export class HouseeditComponent implements OnInit {

editHouseDetails:House={
houseid:'',
name:'',
price:0,
age:0,
imageurl:''
};




constructor(private houseService:HouseserviceService,private router:Router,private route:ActivatedRoute){}
  ngOnInit(): void {

   
    
     
    this.route.paramMap.subscribe({
    next:(params)=>
    {
      const id=params.get('houseid');
      if(id)
      {
        this.houseService.getHouseById('id')
        .subscribe({
          next:(housing)=>{
           this.editHouseDetails=housing;
            console.log(housing);
          }
        })
      }
      
    }
   })
  }

  updateHouse()
  {
    this.houseService.updateHousingDetails(this.editHouseDetails.houseid,this.editHouseDetails)
    .subscribe({
      next:(response)=>
      {
        this.router.navigate(['hlist']);
        console.log(response);
      },
      error:(response)=>
      {
        console.log(response);
      }
    });
  }

  deleteHouse(id:string)
  {
    this.houseService.deleteHousing(id)
    .subscribe({
      next:(response)=>
      {
        this.router.navigate(['hlist']);
      },
      error:(response)=>
      {
        console.log(response);
      }
    });
  }







}
