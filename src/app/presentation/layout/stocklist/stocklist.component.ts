import { Component, OnInit } from '@angular/core';
import { MedicineserviceService } from 'src/app/core/services/medicineservice.service';

@Component({
  selector: 'app-stocklist',
  templateUrl: './stocklist.component.html',
  styleUrls: ['./stocklist.component.scss']
})
export class StocklistComponent implements OnInit {
  dtOptions: DataTables.Settings = {};
  elements: any = [];
  constructor(private service:MedicineserviceService) { }
  ngOnInit(): void {  
  // this.dtOptions = {
  //   pagingType:'full_numbers',
  //   pageLength:5,
  //   lengthMenu:[5, 15, 25],
  //   processing:true
  // };
  setTimeout(()=>{
    $('#medicinetable').DataTable({
      pagingType:'full_numbers',
      pageLength:5,
      lengthMenu:[5, 10, 15],
      processing:true
    });
  },1)
  this.service.getData().subscribe(s=>{
    console.log(s);
    this.elements=s;
    console.log(this.elements)
  });
}
delete(id:number){
  this.service.DeleteMedicine(id).subscribe(res=>
    {
      console.log(res);
      alert('deleted successfully')
      this.ngOnInit();
    })
  //console.log(this.Data.value);
}

}
