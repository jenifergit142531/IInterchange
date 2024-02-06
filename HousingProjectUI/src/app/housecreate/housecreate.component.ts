import { Component, OnInit } from '@angular/core';
import { HouseserviceService } from '../houseservice.service';
import { Router } from '@angular/router';
import { House } from '../house';

@Component({
  selector: 'app-housecreate',
  templateUrl: './housecreate.component.html',
  styleUrl: './housecreate.component.css'
})
export class HousecreateComponent implements OnInit {

  addHousingRequest:House={
    id:'',
    name:'',
    price:0,
    age:0,
    imageurl:''
  };

constructor(private houseService:HouseserviceService,private router:Router){}

  ngOnInit(): void {
    
    
  }

  createHouse()
  {
    this.houseService.addHousing(this.addHousingRequest)
    .subscribe({
      next:(house)=>
      {
        this.router.navigate(['hlist']);
        console.log(house);
      },
      error:(response)=>
      {
        console.log(response);
      }
    })
  }





}
