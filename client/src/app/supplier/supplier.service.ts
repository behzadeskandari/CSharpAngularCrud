import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Supplier, SupplierSecond } from 'src/Model/Supplier';
@Injectable({
  providedIn: 'root'
})
export class SupplierService {

  constructor(private http: HttpClient) { }
  baseUrl: string = 'https://localhost:5001/api/Supplier';
  suppliers: any;

  getAllUser() {
    // var ValueHolder = this.http.get('https://localhost:5001/api/Supplier').subscribe((response) => {
    //   this.suppliers = response;
    //   console.log(response, 'responsegetall');
    //   console.log(this.suppliers,'responsegetall2222')
    // }, (error) => {
    //   console.log(error);
    // })
    // console.log(this.suppliers,'uoytside')
    // return this.suppliers;

  }
  create(payload: SupplierSecond) {
    return this.http.post<Supplier>(this.baseUrl, payload);
  }

  getById(id:number) {

    let ReturnedValue = this.http.get<Supplier>(`https://localhost:5001/api/Supplier/${id}`);
    return ReturnedValue;
  }

  update(payload: Supplier) {
    return this.http.put(`https://localhost:5001/api/Supplier/${payload.id}`, payload);
  }


  delete(id:number) {
    var holder = this.http.delete(`https://localhost:5001/api/Supplier/${id}`);
    console.log(holder,'holder')
    return holder;
  }

}
