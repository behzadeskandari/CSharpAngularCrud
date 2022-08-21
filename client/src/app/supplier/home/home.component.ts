import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { SupplierService } from '../supplier.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
  suppliers: any;
  constructor(public supplierService:SupplierService,private http: HttpClient) { }

  ngOnInit(): void {
    this.getAllUser();
  }



  getAllUser() {
    var ValueHolder = this.http.get('https://localhost:5001/api/Supplier').subscribe((response) => {
      this.suppliers = response;
      console.log(response,'response');
    }, (error) => {
      console.log(error);
    })
    return ValueHolder;

  }

}
