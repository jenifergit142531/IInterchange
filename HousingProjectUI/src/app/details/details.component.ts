import { Component, OnInit } from '@angular/core';
import { House } from '../house';
import { ActivatedRoute, Router } from '@angular/router';
import { HouseserviceService } from '../houseservice.service';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrl: './details.component.css'
})
export class DetailsComponent implements OnInit {

  details!:House;
    
     
    constructor(private houseService:HouseserviceService,private router:Router,private route:ActivatedRoute){}
      ngOnInit(): void {

        
    
       const id=this.route.snapshot.paramMap.get('houseid');
        this.houseService.getDetails('id').subscribe(details=>{
          this.details=details;
        });
}
}
