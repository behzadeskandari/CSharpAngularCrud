import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
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
  allSupplier: Supplier[] = [];
  p: any;
  isfetching: boolean = true;
  error = null;
  constructor(
    public supplierService: SupplierService,
    private http: HttpClient) { }


  ngOnInit(): void {

    // this.deleteModal = new window.bootstrap.Modal(
    //   document.getElementById('deleteModal')
    // );

    this.getAllUser();
  }



  getAllUser() {
    this.isfetching = true;
    this.http.get('https://localhost:5001/api/Supplier').subscribe((response) => {
      this.suppliers = response;
      console.log(response, 'response');
      this.isfetching = false;

    }, (error) => {
      console.log(error);
      this.error = error.message;
    })

  }
  Delete(id: number) {
    console.log(id);
    console.log('delete');
    this.supplierService.delete(id).subscribe(res => {
      this.getAllUser();
    });
  }
}
