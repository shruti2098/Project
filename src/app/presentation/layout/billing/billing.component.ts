import { Component, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { BillingService } from 'src/app/core/services/billing.service';
import { MedicineserviceService } from 'src/app/core/services/medicineservice.service';

@Component({
  selector: 'app-billing',
  templateUrl: './billing.component.html',
  styleUrls: ['./billing.component.scss']
})
export class BillingComponent implements OnInit {
Billing!:FormGroup
list:any;
name:any;
showRate:any;
rateData:any;
datavalue:any;
response:any;
elements:any;

changedata(e:any){
  this.datavalue=e.target.value;
}
  constructor(private service:BillingService,private medicineservice:MedicineserviceService) { }

  ngOnInit(): void {
    this.medicineservice.getData().subscribe(data=>
      {
        this.list=data;
      })

      // this.service.getBillData().subscribe(s=>{
      //   console.log(s);
      //   this.elements=s;
      //   console.log(this.elements)
      // });
  }
  onSubmit(){

    console.log(this.Billing.value);
    // this.service.getPost(this.Billing.value).subscribe(s=>{
     
    //   console.log('in')
    // this.response=s;
    // console.log(s);
    // });
  

  }
  

}
