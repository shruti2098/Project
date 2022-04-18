import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { Billing } from '../models/billing';

@Injectable({
  providedIn: 'root'
})
export class BillingService {

  constructor(private http:HttpClient ) { }
  getPost(Model:Billing): Observable<Billing[]> {
    return this.http.post<Billing[]>('https://localhost:44334/api/Billing/AddBill',Model)
  }
  getBillData(): Observable<Billing[]> {
    return this.http.get<Billing[]>('https://localhost:44334/api/Billing/GetBills')
  }
  
}
