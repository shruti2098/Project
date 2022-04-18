import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { Data } from '../models/data';
//import { HttpClient } from '@angular/common/http';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Medicine } from '../models/medicine';
import { Register } from '../models/register';

@Injectable({
  providedIn: 'root'
})
export class MedicineserviceService {
  apiurl='https://localhost:44334/api/Authentication/login'
  apiurls='https://localhost:44334//api​/Authentication​/register'

  constructor(private http: HttpClient  ) { }
  getToken(){
    return localStorage.getItem('token');
  }
  proceedLogin(usercred:Data):Observable<Data>{
    return this.http.post<Data>(this.apiurl,usercred)
  }
  proceedRegister(usercred:Register):Observable<Register>{
    return this.http.post<Register>(this.apiurls,usercred)
  }
  getPost(Model:Medicine): Observable<Medicine[]> {
    return this.http.post<Medicine[]>('https://localhost:44334/api/Medicine/AddMedicineType',Model)
  }
  getData(): Observable<Data[]> {
    return this.http.get<Data[]>('https://localhost:44334/api/Medicine/GetMedicine')
  }
  GetMedicineById(id:number):Observable<Data[]>{
    let params=new HttpParams();
    params=params.append('id',id);
    return this.http.get<Data[]>('https://localhost:44334/api/Medicine/GetMedicineById',{params:params})
  }
  UpdateMedicine(id:number):Observable<Data[]>{
    return this.http.put<Data[]>('https://localhost:44334/api/Medicine/UpdateMedicine',id)
  }
  DeleteMedicine(id:number):Observable<Data>{
    let params=new HttpParams();
    params=params.append('id',id);
    return this.http.delete<Data>(`https://localhost:44334/api/Medicine/DeleteMedicine/${id}`)
  }
}
