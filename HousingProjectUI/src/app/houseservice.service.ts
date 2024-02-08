import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { House } from './house';

@Injectable({
  providedIn: 'root'
})
export class HouseserviceService {

  baseApiUrl:string="https://localhost:7186";

  baseUrl:string="https://localhost:7186/api/houses";

  baseUrlAuth:string="https://localhost:7186/api/auth";

  constructor(private http:HttpClient) { }

  getAllHouses():Observable<House[]>
  {
     return this.http.get<House[]>(this.baseApiUrl+'/api/houses');
  }

  addHousing(addHousingRequest:House):Observable<House[]>
  {
    addHousingRequest.houseid='00000000-0000-0000-0000-000000000000';
    return this.http.post<House[]>(this.baseApiUrl+'/api/houses',addHousingRequest);
  }

  getHouseById(id:string):Observable<House>
  {
    
    
     return this.http.get<House>(this.baseApiUrl+'/api/houses/'+id);
  }

  updateHousingDetails(id:string,updateHouseDet:House):Observable<House[]>
  {
      return this.http.put<House[]>(this.baseApiUrl+'/api/houses/'+id,updateHouseDet);
  }


  deleteHousing(id:string):Observable<House>
  {
    return this.http.delete<House>(this.baseApiUrl+'/api/houses/'+id);
  }

  getDetails(id:string):Observable<House>{
    const url=`${this.baseUrl}/${id}}`;
    return this.http.get<House>(url);
  }
  
  login(username:string,password:string)
  {
    return this.http.post<any>(`${this.baseUrlAuth}/login`,{username,password});
  }
}
