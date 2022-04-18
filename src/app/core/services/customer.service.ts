import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { Medicine } from '../models/medicine';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {

  constructor(private http: HttpClient) { }
  getPost(Model:Medicine): Observable<Medicine[]> {
    return this.http.post<Medicine[]>('https://localhost:44334/api/Medicine/AddMedicineType',Model)
  }
  GetMedicineById(id:number):Observable<Medicine[]>{
    let params=new HttpParams();
    params=params.append('id',id); 
    return this.http.get<Medicine[]>('https://localhost:44334/api/Customer/GetCustomereById',{params:params})
  }
  UpdateMedicine(id:number):Observable<Medicine[]>{
    return this.http.put<Medicine[]>('https://localhost:44334/api​/Customer​/UpdateCustomer',id)
  }
  DeleteMedicine(id:number):Observable<Medicine>{
    let params=new HttpParams();  
    params=params.append('id',id);
    return this.http.delete<Medicine>(`https://localhost:44334/api/Customer/DeleteCustomer${id}`)
  }

}
