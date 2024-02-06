import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { House } from './house';

@Injectable({
  providedIn: 'root'
})
export class HouseserviceService {

  baseApiUrl:string="https://localhost:7186";
  constructor(private http:HttpClient) { }

  getAllHouses():Observable<House[]>
  {
     return this.http.get<House[]>(this.baseApiUrl+'/api/houses');
  }

  addHousing(addHousingRequest:House):Observable<House[]>
  {
    addHousingRequest.id='00000000-0000-0000-0000-000000000000';
    return this.http.post<House[]>(this.baseApiUrl+'/api/houses',addHousingRequest);
  }
}
