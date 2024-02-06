import { Component, OnInit } from '@angular/core';
import { HouseserviceService } from '../houseservice.service';
import { House } from '../house';

@Component({
  selector: 'app-houselist',
  templateUrl: './houselist.component.html',
  styleUrl: './houselist.component.css'
})
export class HouselistComponent implements OnInit {

  houses:House[]=[];
  constructor(private houseService:HouseserviceService){}
  ngOnInit(): void {
    this.houseService.getAllHouses()
    .subscribe({
      next:(houses)=>
      {
        this.houses=houses;
      },
      error:(response)=>
      {
        console.log(response);
      }
      
    })
  }


}
