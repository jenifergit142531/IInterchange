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

editBookDetails:House={
id:'',
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
      const id=params.get('id');
      if(id)
      {
        this.houseService.getHouseById(id)
        .subscribe({
          next:(response)=>{
            this.editBookDetails=response;
          }
        })
      }
      
    }
   });
  }

  updateHouse()
  {
    this.houseService.updateHousingDetails(this.editBookDetails.id,this.editBookDetails)
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







}
