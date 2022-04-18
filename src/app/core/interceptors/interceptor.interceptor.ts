import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor
} from '@angular/common/http';
import { Observable } from 'rxjs';
import { AuthService } from '../gaurd/auth.service';
import { MedicineserviceService } from '../services/medicineservice.service';

@Injectable()
export class InterceptorInterceptor implements HttpInterceptor {

  constructor(private service:MedicineserviceService) {}

  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    
    const token=this.service.getToken();
    if(token){
      const request=req.clone({headers:req.headers.set('Authorization',`Bearer ${token}`)});
      
    }
    return next.handle(req);
  }

}
