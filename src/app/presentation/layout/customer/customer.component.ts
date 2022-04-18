import { Component, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { MedicineserviceService } from 'src/app/core/services/medicineservice.service';

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.scss']
})
export class CustomerComponent implements OnInit {
  Customer!: FormGroup;
  response:any;
  constructor(private service:MedicineserviceService) { }

  ngOnInit(): void {
  }
  get f(){
    return this.Customer.controls;    
  }
  onSubmit(){
    console.log(this.Customer.value);
    this.service.getPost(this.Customer.value).subscribe(s=>{ 
      console.log('in')
    this.response=s;
    console.log(s);
    });
  }
}
