import { Supplier } from 'src/Model/Supplier';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { SupplierService } from '../supplier.service';

@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.scss']
})
export class EditComponent implements OnInit {

  supplierForm: Supplier = {
    id: 0,
    firstName: '',
    lastName: '',
  }


  constructor(private route:ActivatedRoute,private router:Router,private supplierService:SupplierService) { }

  ngOnInit(): void {

    this.route.paramMap.subscribe((param) => {
      var id = Number(param.get('id'));
      this.getById(id);
    })

  }

  getById(id: number) {
    this.supplierService.getById(id).subscribe((data) => {
      console.log(data,'dataaa')
      this.supplierForm = data;
    });
  }

  update() {
    this.supplierService.update(this.supplierForm).subscribe({
      next: (data) => {
        this.router.navigate(["/supplier/home"])
      },
      error: (err) => {
        console.log(err);
      }
    })
  }


}
