import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Supplier, SupplierSecond } from 'src/Model/Supplier';
@Injectable({
  providedIn: 'root'
})
export class SupplierService {

  constructor(private http: HttpClient) { }
  baseUrl: string = 'https://localhost:44315/api/Supplier';
  suppliers: any;

  getAllUser(page : number,itemsPerPage: number) {
    return this.http.get(`https://localhost:44315/api/Supplier?PageNumber=${page}&PageSize=${itemsPerPage}`);

  }
  create(payload: SupplierSecond) {
    return this.http.post<Supplier>(this.baseUrl, payload);
  }

  getById(id:number) {

    let ReturnedValue = this.http.get<Supplier>(`https://localhost:44315/api/Supplier/${id}`);
    return ReturnedValue;
  }

  update(payload: Supplier) {
    return this.http.put(`https://localhost:44315/api/Supplier/${payload.id}`, payload);
  }


  delete(id:number) {
    var holder = this.http.delete(`https://localhost:44315/api/Supplier/${id}`);
    console.log(holder,'holder')
    return holder;
  }

}
