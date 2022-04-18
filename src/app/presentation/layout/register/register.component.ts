import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { MedicineserviceService } from 'src/app/core/services/medicineservice.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {
  registerform!:FormGroup
  response:any
  constructor(private authservice:MedicineserviceService,private router:Router,private fb:FormBuilder) { }

  ngOnInit(): void {
    this.registerform=this.fb.group({
      username:['',Validators.required],
      password:['',Validators.required],
      email:['',Validators.required],
      mobileno:['',Validators.required],
      birthdate:['',Validators.required]
    })
  }
  get f(){
    return this.registerform.controls;
  }
  onSubmit(){
    //alert('please enter the username')
    console.log(this.registerform.value);
    alert('Registered successfully')
    this.authservice.proceedRegister(this.registerform.value).subscribe(res => {
      console.log('in')
    this.response=res;
    console.log(res);
    console.log(this.response.token)
    localStorage.setItem("token",this.response.token);
    //this.router.navigateByUrl('home')
    
    })
  }

}
