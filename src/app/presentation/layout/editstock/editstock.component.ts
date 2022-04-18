import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { MedicineserviceService } from 'src/app/core/services/medicineservice.service';

@Component({
  selector: 'app-editstock',
  templateUrl: './editstock.component.html',
  styleUrls: ['./editstock.component.scss']
})
export class EditstockComponent implements OnInit {

  Medicine!: FormGroup;
  id!:number
  elements:any;
  listdata:any;
  response:any;
  Data={}

  
  
  constructor(private fb:FormBuilder,private service:MedicineserviceService,private route:Router,private router:ActivatedRoute) {
    //this.listdata=[];
    
    this.Medicine=this.fb.group({
      id:['',Validators.required],
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
    this.id=Number(this.router.snapshot.paramMap.get('id'))
    console.log(this.id);
    this.service.GetMedicineById(this.id).subscribe(a=>{
      console.log(a);
      this.Data=a;
      this.Medicine.patchValue(this.Data);
    })

    this.service.getData().subscribe(s=>{
      console.log(s);
      this.elements=s;
      console.log(this.elements)
    });
    
    
  }
  
  Edit(){
    console.log(this.Medicine.value);
    this.service.UpdateMedicine(this.Medicine.value).subscribe(res => {
      alert('Medicine updated successfully')
      console.log(res);
      this.route.navigateByUrl('home')
    })
  }
  get f(){

    return this.Medicine.controls;
    

  }
  

  onSubmit(){

    console.log(this.Medicine.value);
    this.service.UpdateMedicine(this.Medicine.value).subscribe(s=>{
     
     // console.log('in')
    // this.response=s;
    console.log(s);
    this.route.navigateByUrl('home/list')
    });
  

  }

}
