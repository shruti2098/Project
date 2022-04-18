import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/core/gaurd/auth.service';
import { MedicineserviceService } from 'src/app/core/services/medicineservice.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  //loginForm:FormGroup
  loginform!:FormGroup
  response:any
  


  constructor(private authservice:MedicineserviceService,private router:Router,private fb:FormBuilder) {
    this.loginform=this.fb.group({
      username:['',[Validators.required]],
      password:['',[Validators.required]],
      

    })
   }

  ngOnInit(): void {
    this.loginform=this.fb.group({
      username:['',Validators.required],
      password:['',Validators.required]
    })
  }
  get f(){
    return this.loginform.controls;
  }
  onSubmit(){
    
    console.log(this.loginform.value);
    this.authservice.proceedLogin(this.loginform.value).subscribe(res => {
      alert('User login successfully')
    //  console.log('in')
    this.response=res;
    console.log(res);
    console.log(this.response.token)
    localStorage.setItem("token",this.response.token);
    this.router.navigateByUrl('home')
    
    })
  
  }
  
}
  