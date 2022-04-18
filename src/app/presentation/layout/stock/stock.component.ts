import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { MedicineserviceService } from 'src/app/core/services/medicineservice.service';

@Component({
  selector: 'app-stock',
  templateUrl: './stock.component.html',
  styleUrls: ['./stock.component.scss']
})
export class StockComponent implements OnInit {
  Medicine!: FormGroup;
  
  listdata:any;
  response:any;
  
  constructor(private fb:FormBuilder,private service:MedicineserviceService,private route:Router) {
    this.listdata=[];
    
    this.Medicine=this.fb.group({
      //Id:['',[Validators.required,Validators.minLength(3)]],
      name:['',Validators.required],
      type:['',Validators.required],
      unitPrice:['',Validators.required],
      manufacturer:['',Validators.required],
      quantity:['',Validators.required],
      description:['',Validators.required],
      expiryDate:['',Validators.required]
      

    })
    
   }
  //  public addItem(): void{
  //    this.listdata.push(this.supplier.value)
  //    this.supplier.reset();
  //  }
  //  reset(){
  //    this.supplier.reset();
  //  }

  ngOnInit(): void {
    
  }
  get f(){

    return this.Medicine.controls;
    

  }
  

  onSubmit(){

    console.log(this.Medicine.value);
    this.service.getPost(this.Medicine.value).subscribe(s=>{
     alert('Medicine added successfully');
     // console.log('in')
    // this.response=s;
    console.log(s);
   
    this.route.navigateByUrl('home/list')
    });
  

  }
}
