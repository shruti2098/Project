import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './presentation/layout/home/home.component';
import { LoginComponent } from './presentation/layout/login/login.component';
import { RegisterComponent } from './presentation/layout/register/register.component';
import { StockComponent } from './presentation/layout/stock/stock.component';

const routes: Routes = [
  {
    path: '',
    component: LoginComponent
  },
  // {
  //   path: 'login',
  //   component: LoginComponent
  // },
  {
    path: 'register',
    component: RegisterComponent
  },
  // {
  //   path: 'stock',
  //   component: StockComponent
  // },
  {
    path:'home', loadChildren: () => import('./presentation/layout/home/home.module').then(m => m.HomeModule)
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
