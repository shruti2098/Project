import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CustomerComponent } from './presentation/layout/customer/customer.component';
import { StockComponent } from './presentation/layout/stock/stock.component';
import { LoginComponent } from './presentation/layout/login/login.component';
import { HttpClient, HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RegisterComponent } from './presentation/layout/register/register.component';
import { HomeComponent } from './presentation/layout/home/home.component';
import { BillingComponent } from './presentation/layout/billing/billing.component';
import { EditstockComponent } from './presentation/layout/editstock/editstock.component';
import { StocklistComponent } from './presentation/layout/stocklist/stocklist.component';
;
import { DatePipe } from '@angular/common';
import { InterceptorInterceptor } from './core/interceptors/interceptor.interceptor';

@NgModule({
  declarations: [
    AppComponent,
    
    LoginComponent,
    RegisterComponent,
    HomeComponent,
  
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule
    
  ],
  providers: [{
    provide:HTTP_INTERCEPTORS,useClass:InterceptorInterceptor,multi:true
  }],
  bootstrap: [AppComponent]
})
export class AppModule { }
