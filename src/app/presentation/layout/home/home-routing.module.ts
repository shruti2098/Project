import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BillingComponent } from '../billing/billing.component';
import { CustomerComponent } from '../customer/customer.component';
import { EditstockComponent } from '../editstock/editstock.component';
import { StockComponent } from '../stock/stock.component';
import { StocklistComponent } from '../stocklist/stocklist.component';
import { HomeComponent } from './home.component';

const routes: Routes = [{
  path:'',

  component:HomeComponent,
  
  children:[{
    path:'stock',
    component:StockComponent
  },
  {
    path:'customer',
    component:CustomerComponent
  
  },
  {
    path:'billing',
    component:BillingComponent
  },
  {
    path:'list',
    component:StocklistComponent
  },
  {
    path:'editstock/:id',
    component:EditstockComponent
  }
  

]

},

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class HomeRoutingModule { }
