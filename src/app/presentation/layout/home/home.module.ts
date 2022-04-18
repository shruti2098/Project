import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HomeRoutingModule } from './home-routing.module';
import { DataTablesModule } from 'angular-datatables';
import { StocklistComponent } from '../stocklist/stocklist.component';
import { StockComponent } from '../stock/stock.component';
import { CustomerComponent } from '../customer/customer.component';
import { BillingComponent } from '../billing/billing.component';
import { ReactiveFormsModule } from '@angular/forms';
import { EditstockComponent } from '../editstock/editstock.component';


@NgModule({
  declarations: [
    StocklistComponent,
    StockComponent,
    CustomerComponent,
    BillingComponent,
    EditstockComponent
  ],
  imports: [
    CommonModule,
    HomeRoutingModule,
    DataTablesModule,
    ReactiveFormsModule
    
  
  ]
})
export class HomeModule { }
