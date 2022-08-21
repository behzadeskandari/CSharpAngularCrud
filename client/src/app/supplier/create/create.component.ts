import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Supplier, SupplierSecond } from 'src/Model/Supplier';
import { SupplierService } from '../supplier.service';

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.scss']
})
export class CreateComponent implements OnInit {

  supplierForm: SupplierSecond = {
    // id: 0,
    FirstName: '',
    LastName:'',
  }
  constructor(private supplierService:SupplierService,private router:Router) { }

  ngOnInit(): void {
  }

  create() {
    this.supplierService.create(this.supplierForm).subscribe({
      next: (data) => {
        this.router.navigate(["/supplier/home"])
      },
      error:(err) => {
        console.log(err);
      }
    })
  }



}
