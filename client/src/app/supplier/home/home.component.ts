import { HttpClient } from '@angular/common/http';
import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { Supplier } from 'src/Model/Supplier';
import { SupplierService } from '../supplier.service';


declare var window: any;
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
  suppliers: any;
  data: any;
  allSupplier: Supplier[] = [];
  p: any;
  isfetching: boolean = true;
  error = null;
  @ViewChild('localRefrence', {static:false}) localRefrence: any ;
  constructor(
    public supplierService: SupplierService ,
    private http: HttpClient) { }


  ngOnInit(): void {

    this.getAllUser();

  }

  // buttonCLcik() {
  //   console.log(this.localRefrence,'mRef');

  //   console.log(this.localRefrence?.nativeElement.formAction,'mRef2222');
  //   console.log(this.localRefrence?.nativeElement.value,'elemRef');
  // }

  // OnAddServer(inputElm : HTMLInputElement) {
  //   console.log(inputElm.value);
  //   inputElm.value = "behzad eskandari";
  // }

  getAllUser() {
    this.isfetching = true;
    this.supplierService.getAllUser().subscribe((response) => {
      this.suppliers = response;
        this.data = this.suppliers.data
        console.log(response, 'response');

        console.log(this.data, 'data');
        this.isfetching = false;

      },
      (error) => {
        console.log(error);
        this.error = error.message;
      })

    // this.http.get(`https://localhost:44315/api/Supplier?PageNumber=1&PageSize=10`).subscribe((response) => {
    //   this.suppliers = response;
    //   this.data = this.suppliers.data
    //   console.log(response, 'response');

    //   console.log(this.data, 'data');
    //   this.isfetching = false;

    // }, (error) => {
    //   console.log(error);
    //   this.error = error.message;
    // })

  }
  Delete(id: number) {

    console.log(id);
    console.log('delete');
    this.supplierService.delete(id).subscribe(res => {
      this.getAllUser();
    });
  }
}
