import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Supplier } from 'src/Model/Supplier';
@Injectable({
  providedIn: 'root'
})
export class SupplierService {

  constructor(private http: HttpClient) { }
  baseUrl: any = 'https://localhost:5001';





}
